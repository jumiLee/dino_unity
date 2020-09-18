using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMainPacket : HeaderPacket
{
    public UserDetail userDetail;   //user detail info 

    public UserNotice userNotice;   //new flag

    public List<UserMonsterList> userMonsterList; // my dinosaurs info
}