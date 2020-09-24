
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System;

using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Networking;

public class HttpSock : MonoBehaviour
{

    private static Mutex mut = new Mutex();

    //  string MainURL ="http://localhost:8080/dino/";  //loca test url
    string MainURL = "http://ec2-54-180-134-196.ap-northeast-2.compute.amazonaws.com:8080/dino/";  //amazon server url

    public string Connect(string URL, String sdString)
    {

        mut.WaitOne(); //동기화를 위한 락걸어주는 부분 

        string res = MetConnect(MainURL + URL, sdString);

        mut.ReleaseMutex(); //동기화를 위한 락 풀어주는 부분 
        Debug.Log(res);
        return res;
    }

        public string MetConnect(string URL, String sdString)
    {
        try
        {
            // 인코딩 1 - UTF-8  
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.Method = "POST";
            myRequest.Timeout = 20000;//10초 타임아웃 
            byte[] sendData = UTF8Encoding.UTF8.GetBytes(sdString);
            myRequest.ContentLength = sendData.Length;

            Stream requestStream = myRequest.GetRequestStream();
            requestStream.Write(sendData, 0, sendData.Length);
            requestStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();

            sr.Close();
            myResponse.Close();
            result = result.Trim();
            return result;
        }
        catch (System.Net.WebException SCE)
        {

            Debug.Log("접속지연 : " + SCE.ToString());
            return "";
        }
    }

    /*
public string Connect(string URL, WWWForm sdString)
{

    Debug.Log("sdString:" + sdString.ToString());


    mut.WaitOne(); //동기화를 위한 락걸어주는 부분 

    string res = MetConnect(MainURL + URL, sdString);

    mut.ReleaseMutex(); //동기화를 위한 락 풀어주는 부분 
    Debug.Log(res);
    return res;
}

public string MetConnect(string URL, WWWForm form)
{
    Debug.Log("URL:" + URL);

    UnityWebRequest www = UnityWebRequest.Post(URL, form);
    yield return www.Send();

}
  */

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
