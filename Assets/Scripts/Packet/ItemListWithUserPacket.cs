using System;
using System.Collections.Generic;

[Serializable]
public class ItemListWithUserPacket : HeaderPacket
{
	public List<ItemList> itemList;

	public UserDetail userDetail;
}
