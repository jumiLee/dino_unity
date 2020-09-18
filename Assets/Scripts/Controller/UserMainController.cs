using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMainController : MonoBehaviour
{
    public string basic_url_real = "ec2-54-180-134-196.ap-northeast-2.compute.amazonaws.com:8080/dino/";
    public int user_account;
    public string jsonURL = "userMain.do";
    
    void Start()
    {
        string _url = basic_url_real.ToString() + jsonURL.ToString() + "?user_account=".ToString() + user_account.ToString();
        Debug.Log(_url);
        processJsonData(_url);
        
    }

         
    public UserMainPacket processJsonData(string _url)
    {
        UserMainPacket userMainPacket = JsonUtility.FromJson<UserMainPacket>(_url);
        Debug.Log(userMainPacket.account);
        Debug.Log(userMainPacket.userMonsterList);
        Debug.Log(userMainPacket.userNotice.monsterNewFlag);

        return userMainPacket;
    }

    
}
