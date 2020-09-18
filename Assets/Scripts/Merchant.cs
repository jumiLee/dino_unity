using System;
using System.Collections.Generic;

[Serializable]
public class MerchantInfoPacket
{
    public Merchant merchant;
}

[Serializable]
public class Merchant
{
    public int mctId;
    public string mctName;
    public string mctEmail;
    public string mctPwd;
    public string mct_desc;
    public string createDate;
    public string lastModifyDate;
}