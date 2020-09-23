using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserMainController : MonoBehaviour
{
    public int user_account ;
    public GameObject HttpObject;

    void Start()
    {
     
    }

    //T000 : 메인정보요청(공룡정보포함)
    public UserMainPacket userMainPacket; 
    public void userMain(int _user_account)
    {
        user_account = _user_account;
        string jsonURL = "userMain.do";
        string parameters = "user_account=" + user_account;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            userMainPacket = JsonUtility.FromJson<UserMainPacket>(json);
        }
    }

    //T001 : 회원가입
    public InputField emailText;
    public InputField pwdText;
    public InputField nicknameText;
    public string email;
    public string pwd;
    public string nickname;
    public MemberInfoPacket memberInfoPacket;
    public void register()
    { 
        email =emailText.text;
        pwd = pwdText.text;
        nickname = nicknameText.text;
        
        string jsonURL = "register.do";
        string parameters = "email=" + email 
                          + "&pwd=" + pwd 
                          + "&nickname=" + nickname;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            memberInfoPacket = JsonUtility.FromJson<MemberInfoPacket>(json);
        }

    }

    //T001 : login check
    public void loginChk()
    {
        email = emailText.text;
        pwd = pwdText.text;

        string jsonURL = "loginChk.do";
        string parameters = "email=" + email+ "&pwd=" + pwd;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            memberInfoPacket = JsonUtility.FromJson<MemberInfoPacket>(json);
        }
    }

    //T003 : 상점아이템정보
    public ItemListWithUserPacket itemListWithUserPacket;
    public void itemList(int _user_account)
    {
        user_account = _user_account;

        string jsonURL = "itemList.do";
        string parameters = "user_account=" + user_account;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            itemListWithUserPacket = JsonUtility.FromJson<ItemListWithUserPacket>(json);
        }
    }

    //T004 : 아이템 구매 
    public InputField itemIdText;
    public InputField itemCntText;
    public int itemId;
    public int itemCnt;

    public ItemPacket itemPacket;
    public void buyItem(int _user_account)
    {
        itemId = int.Parse(itemIdText.text);
        itemCnt = int.Parse(itemCntText.text);

        string jsonURL = "buyItem.do";
        string parameters = "user_account=" + _user_account 
                                     + "&item_id=" + itemId
                                     + "&item_cnt=" + itemCnt;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            itemPacket = JsonUtility.FromJson<ItemPacket>(json);
        }
    }

    //T100 : 상점정보 조회
    public MerchantInfoPacket merchantInfoPacket;
    public void mctLoginChk(int _user_account)
    {
        email = emailText.text;
        pwd = pwdText.text;

        string jsonURL = "mctLoginChk.do";
        string parameters = "email=" + email + "&pwd=" + pwd;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            merchantInfoPacket = JsonUtility.FromJson<MerchantInfoPacket>(json);
        }
    }
}