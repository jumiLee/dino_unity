using System;
using System.Collections.Generic;

[Serializable]
public class MemberInfoPacket : HeaderPacket{
    public string sid;
    public UserDetail userDetail;	//user detail info 
}
