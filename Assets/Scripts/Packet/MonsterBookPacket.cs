using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MonsterBookPacket : HeaderPacket
{
    public List<UserMonsterList> userMonsterBookList;
}
