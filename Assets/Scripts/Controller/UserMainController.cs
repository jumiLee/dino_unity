using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UserMainController : MonoBehaviour
{
    public int user_account ;
    public GameObject HttpObject;

    void Start()
    {
     
    }

    /*
     * T000 : 메인정보요청(공룡정보포함)
     * */
    public UserMainPacket userMainPacket; 
    public void userMain(int _user_account)
    {
        user_account = _user_account;
        string jsonURL = "userMain.do";
        string parameters = "user_account=" + user_account;

        Debug.Log("parameters:" + parameters);

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);

        userMainPacket = JsonUtility.FromJson<UserMainPacket>(json);

        //return userMainPacket;
    }
    /*
 public void userMain()
 {
     string jsonURL = "userMain.do";
     WWWForm parameters = new WWWForm();
     parameters.AddField("user_account", user_account);

     string json = httpSock.Connect(jsonURL, parameters.ToString());
     userMainPacket = JsonUtility.FromJson<UserMainPacket>(json);

     //return userMainPacket;
 }
     */
}
