using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopmuluManager : MonoBehaviour
{
	public static TopmuluManager _Instance;
	public List<GameObject> onePase = new List<GameObject>();
	public List<GameObject> twoPase = new List<GameObject>();
	//上下页
	public Button btn_previouspage;
	public Button btn_nextpage;
	public int index = 0;
	private void Awake()
	{
		_Instance = this;
	}
	void Start()
	{
		btn_nextpage.onClick.AddListener(Nextpage);
		btn_previouspage.onClick.AddListener(Previouspage);
	}

	public void Previouspage()
	{
		if (index == 0)
		{
			return;
		}
		index--;
		SetPase();
	}

	public void Nextpage()
	{
		if (index == 1)
		{
			return;
		}
		index++;
		SetPase();
	}

	private void SetPase()
	{
		if (index == 0)
		{
			for (int i = 0; i < onePase.Count; i++)
			{
				onePase[i].gameObject.SetActive(true);
				twoPase[i].gameObject.SetActive(false);
				twoPase[i].gameObject.GetComponent<Toggle>().isOn = false;
			}
		}
		else if (index == 1)
		{
			for (int i = 0; i < onePase.Count; i++)
			{
				onePase[i].gameObject.SetActive(false);
				onePase[i].gameObject.GetComponent<Toggle>().isOn = false;
				twoPase[i].gameObject.SetActive(true);
			}
		}
	}
}
