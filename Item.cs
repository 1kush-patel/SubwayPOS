using System;

public class Item
{
	public decimal itemPrice;
	public string itemType;
	public string itemSize;
	public string itemDescription;
	public Item(decimal price, string description, string size)
	{
		itemType = description;
		itemPrice = price;	
		itemSize = size;
		itemDescription = ToString();
	}

	public override string ToString() 
	{ 
		return itemSize +"  " itemType +"..............." + itemPrice.ToString();
	}
}
