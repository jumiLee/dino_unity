using System;
using System.Collections.Generic;

[Serializable]
public class jsonDataClass
{
    public string playerName;
    public List<ballList> balls;
}

[Serializable]
public class ballList
{
    public string name;
    public string description;
    public int price;
    public string image;
    public int size;
    public string weight;
    public string free;
}

[Serializable] 
public class loadingimg
{
    public string image;
}