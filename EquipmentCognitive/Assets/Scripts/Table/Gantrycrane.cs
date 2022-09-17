using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gantrycrane : ITableItem
{
	public int ID;

	public string Title;

	public string Content;

	public int Key()
	{
		return ID;
	}
}
public class GantrycraneManager : TableManager<Gantrycrane, GantrycraneManager>
{
	public override string TableName()
	{
		return "gantrycrane";
	}
}
