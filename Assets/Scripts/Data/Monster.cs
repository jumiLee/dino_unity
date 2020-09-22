using System;
using System.Collections.Generic;

[Serializable]
public class Monster
{
    public int monId;       //공룡 아이디
    public string monNm;    //공룡이름	
    public int monType;     //1.육식, 2.초식, 3.잡식
    public int monMaxLv;    //최대레벨
    public string monDesc;	//공룡 설명
}
