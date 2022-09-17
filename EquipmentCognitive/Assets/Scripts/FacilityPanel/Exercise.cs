using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : ITableItem
{

	public int ID;
	public int EquipmentID;
	public string Problem;
	public string A;
	public string B;
	public string C;
	public string D;
	public string Answer;

	public int Key()
	{
		return ID;
	}
}
public class ExerciseManager : TableManager<Exercise, ExerciseManager>
{
	public override string TableName()
	{
		return "Exercise";
	}
	public Exercise[] GetItemsByEquipmentID(int _EquipmentID)
	{
		Exercise[] exercises = GetAllItem();
		List<Exercise> lst = new List<Exercise>();
		for (int i = 0; i < exercises.Length; i++)
		{
			if (exercises[i].EquipmentID == _EquipmentID)
			{
				lst.Add(exercises[i]);
			}
		}
		return lst.ToArray();
	}
	public bool OnAnswer(Exercise exercise, string answer)
	{
		if (exercise.Answer == answer)
		{
			Debug.Log("选择正确");
			return true;
		}
		return false;
	}
}
