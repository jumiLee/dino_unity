using System;
using System.Collections.Generic;

[Serializable]
public class ItemPacket : HeaderPacket
{
    public ItemList itemList;

    public int itemUniqueID;
}
