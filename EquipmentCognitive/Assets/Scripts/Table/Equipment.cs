using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : ITableItem
{
    public int ID;

    public string EquipmentName;

    public string PrefabName;

    public int Type;

    public int Key()
    {
        return ID;
    }
}
public class EquipmentManager : TableManager<Equipment, EquipmentManager>
{
    public override string TableName()
    {
        return "equipment";
    }
}
