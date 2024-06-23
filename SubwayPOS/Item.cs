using System;

public class Item
{
	public decimal itemPrice;
	public string itemType;
	public string itemSize;
	public string itemDescription;
	public int itemNumber;
	public Item(decimal price, string size, string type)
	{
		itemSize = size;
		itemType = type;
		itemPrice = price;
		itemDescription = ToString();
	}

	public override string ToString() 
	{ 
		return  itemSize +"  " + itemType +"............" + itemPrice.ToString();
	}
}
