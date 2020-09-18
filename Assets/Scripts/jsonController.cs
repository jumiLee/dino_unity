using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonController 
{
    public string basic_url_real = "ec2-54-180-134-196.ap-northeast-2.compute.amazonaws.com:8080/dino/";

    // Start is called before the first frame update
    /*
     void Start()
    {
        StartCoroutine(getData());
    }

    
    public string IEnumerator getData()
    {

        Debug.Log("Processing Data, Please Wait");

    
        WWW _www = new WWW(basic_url_real+jsonURL);
        yield return _www;

        if (_www.error == null)
        {
            return _www.text;
           // processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Oops something went wrong");
        }
    }

    */
    /*
 private void processJsonData(string _url)
 {


     jsonDataClass jsnData = JsonUtility.FromJson<jsonDataClass>(_url);
     Debug.Log(jsnData.playerName);
     Debug.Log(jsnData.balls);

     foreach (ballList x in jsnData.balls)
     {
         Debug.Log(x.name);
         Debug.Log(x.free);
         Debug.Log(x.description);
     }


     MerchantInfoPacket merchantInfoPacket = JsonUtility.FromJson<MerchantInfoPacket>(_url);
     Debug.Log(merchantInfoPacket.merchant.mctId);
     Debug.Log(merchantInfoPacket.merchant.mctName);
 }
  */
}