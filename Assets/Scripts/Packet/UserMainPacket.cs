using System;
using System.Collections.Generic;

[Serializable]
public class UserMainPacket : HeaderPacket
{
    public UserDetail userDetail;   //user detail info 

    public UserNotice userNotice;   //new flag

    public List<UserMonsterList> userMonsterList; // my dinosaurs info
}