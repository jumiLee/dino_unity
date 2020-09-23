using System;
using System.Collections.Generic;

[Serializable]
public class ItemList
{
    public int itemId;                  //item id
    public string itemNm;           //item name
    public int itemCategory;        //item category  (0:none, 1:meat, 2:vegetable, 3:fruit)
    public int itemType;                //item type(10:food, 20:color)
    public int itemPrice;               //item 가격
    public int unit_cd;                  //item price unit (3:point)
    public string itemDesc;         //item 설명
    public int itemValue;             //item value (itemType이 10이면 적용할 exp, 20이면 적용 색상)
    public int itemCnt;                //아이템 개수
    public int itemPeriodFlag;    //사용안함
    public int itemPeriod;           //사용안함
    public int itemDupFlag;        //사용안함
    public int itemNewFlag;        //사용안함
    public int itemImgNo;           //이미지번호 (item_id와 동일)
}