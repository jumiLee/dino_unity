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
        string parameters = "email="     + email 
                          + "&pwd="      + pwd 
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
        string parameters = "email=" + email
                          + "&pwd="  + pwd;

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
                                     + "&item_id="  + itemId
                                     + "&item_cnt=" + itemCnt;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            itemPacket = JsonUtility.FromJson<ItemPacket>(json);
        }
    }

    //T006 : 아이템 사용 
    public InputField itemUniqueIdText;
    public InputField monIdText;
    public InputField userMonSnText;

    public int itemUniqueId;
    public int monId;
    public int userMonSn;

    public MonsterPacket monsterPacket;
    public void useItem(int _user_account)
    {
        itemUniqueId = int.Parse(itemUniqueIdText.text);
        monId = int.Parse(monIdText.text);
        userMonSn = int.Parse(userMonSnText.text);

        string jsonURL = "useItem.do";
        string parameters = "user_account="     + _user_account
                          + "&item_unique_id="  + itemUniqueId
                          + "&mon_id="          + monId
                          + "&user_mon_sn="     + userMonSn;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            monsterPacket = JsonUtility.FromJson<MonsterPacket>(json);
        }
    }

    //T008 : 도감정보 조회
    public MonsterBookPacket monsterBookPacket;
    public void userMonsterBook(int _user_account)
    {
        email = emailText.text;
        pwd = pwdText.text;

        string jsonURL = "userMonsterBook.do";
        string parameters = "user_account=" + _user_account;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            monsterBookPacket = JsonUtility.FromJson<MonsterBookPacket>(json);
        }
    }

    //T009 : 공룡획득
    public InputField mctIdText;
    public int mctId; 
    public void addMonster(int _user_account)
    {

        monId = int.Parse(monIdText.text);
        mctId = int.Parse(mctIdText.text);

        Debug.Log(monIdText.text);
        Debug.Log(mctIdText.text);
        string jsonURL = "addMonster.do";
        string parameters = "user_account=" + user_account
                          + "&mon_id=" + monId
                          + "&mct_id=" + mctId;

        string json = HttpObject.GetComponent<HttpSock>().Connect(jsonURL, parameters);
        if (json != null)
        {
            monsterPacket = JsonUtility.FromJson<MonsterPacket>(json);
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