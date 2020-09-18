using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderPacket
{
    public int resultCd = 0;                          //result code
    public string resultMsg = "Success";    //result Message
    public int account;

    public void setHeader(int account, int resultCd, string resultMsg)
    {
        this.account = account;
        this.resultCd = resultCd;
        this.resultMsg = resultMsg;
    }
}
