using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Topic : MonoBehaviour
{
	public Transform enghtpage;
	void Start()
	{
		UpdateItem();
	}
	private void UpdateItem()
	{
		switch (transform.parent.parent.parent.name)
		{
			case "gantrycrane":
				Gantrycrane();
				break;
			case "roadrailer":
				Roadrailer();
				break;
			case "straddlecarrier":
				Straddlecarrier();
				break;
			case "emptycontainerstacker":
				Emptycontainerstacker();
				break;
			case "container":
				Container();
				break;
			case "weighbridge":
				Weighbridge();
				break;
			case "trackscale":
				Trackscale();
				break;
			case "flatcar":
				Flatcar();
				break;
			case "reachstacker":
				Reachstacker();
				break;

			default:
				break;
		}
	}
	private void Reachstacker()
	{
		Exercise[] exercise9 = ExerciseManager.Instance.GetItemsByEquipmentID(1009);
		Selectatopic(exercise9);
	}
	private void Flatcar()
	{
		Exercise[] exercise8 = ExerciseManager.Instance.GetItemsByEquipmentID(1008);
		Selectatopic(exercise8);
	}
	private void Trackscale()
	{
		Exercise[] exercise7 = ExerciseManager.Instance.GetItemsByEquipmentID(1007);
		Selectatopic(exercise7);
	}
	private void Weighbridge()
	{
		Exercise[] exercise6 = ExerciseManager.Instance.GetItemsByEquipmentID(1006);
		Selectatopic(exercise6);
	}
	private void Container()
	{
		Exercise[] exercise5 = ExerciseManager.Instance.GetItemsByEquipmentID(1005);
		Selectatopic(exercise5);
	}
	private void Emptycontainerstacker()
	{
		Exercise[] exercise4 = ExerciseManager.Instance.GetItemsByEquipmentID(1004);
		Selectatopic(exercise4);
	}
	private void Straddlecarrier()
	{
		Exercise[] exercise3 = ExerciseManager.Instance.GetItemsByEquipmentID(1003);
		Selectatopic(exercise3);
	}
	private void Roadrailer()
	{
		Exercise[] exercise2 = ExerciseManager.Instance.GetItemsByEquipmentID(1002);
		Selectatopic(exercise2);
	}

	private void Gantrycrane()
	{
		Exercise[] exercise = ExerciseManager.Instance.GetItemsByEquipmentID(1001);
		Selectatopic(exercise);
	}

	private void Selectatopic(Exercise[] exercise)
	{
		for (int i = 0; i < exercise.Length; i++)
		{
			Transform child = enghtpage.GetChild(i);
			Text txt_question = child.Find("txt_question").GetComponent<Text>();
			Text txt_A = child.Find("A").GetComponent<Text>();
			Text txt_B = child.Find("B").GetComponent<Text>();
			Text txt_C = child.Find("C").GetComponent<Text>();
			Text txt_D = child.Find("D").GetComponent<Text>();

			txt_question.text = string.Format("{0}.{1}", i + 1, exercise[i].Problem);
			txt_A.text = "A." + exercise[i].A;
			txt_A.GetComponent<Toggle>().onValueChanged.AddListener(IsTrue);
			txt_B.text = "B." + exercise[i].B;
			txt_B.GetComponent<Toggle>().onValueChanged.AddListener(IsTrue);
			txt_C.text = "C." + exercise[i].C;
			txt_C.GetComponent<Toggle>().onValueChanged.AddListener(IsTrue);
			txt_D.text = "D." + exercise[i].D;
			txt_D.GetComponent<Toggle>().onValueChanged.AddListener(IsTrue);

		}
		Answer(exercise);
	}

	void Answer(Exercise[] exercise)
	{
		Text txt_answer;
		txt_answer = enghtpage.parent.transform.Find("AnswerPanel").transform.Find("txt_answer").GetComponent<Text>();
		string s = exercise[0].Answer;
		string s1 = exercise[1].Answer;
		txt_answer.text = "正确答案:" + s + " 、" + s1;
	}
	private void IsTrue(bool IsOn)
	{
		for (int j = 1; j < this.transform.childCount; j++)
		{
			if (this.transform.GetChild(j).GetComponent<Toggle>().isOn)
			{
				this.transform.GetChild(j).GetComponent<Text>().color = Color.green;
			}
			else
			{
				this.transform.GetChild(j).GetComponent<Text>().color = Color.white;
			}
		}
		if (IsOn)
		{
			IsRightanswers();
		}
	}
	public void IsRightanswers()
	{
		Exercise[] exercises = ExerciseManager.Instance.GetItemsByEquipmentID(1001);

		for (int j = 1; j < this.transform.childCount; j++)
		{
			if (this.transform.GetChild(j).GetComponent<Toggle>().isOn)
			{
				int a = (int.Parse)(this.transform.name);

				print(a);
				print(this.transform.GetChild(j).name);
				if (ExerciseManager.Instance.OnAnswer(exercises[a], this.transform.GetChild(j).name))
				{
				}
			}
		}


	}
}
