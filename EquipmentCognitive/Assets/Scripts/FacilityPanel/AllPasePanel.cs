using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllPasePanel : MonoBehaviour
{
	//上下页
	public Button btn_nextpage;
	public Button btn_previouspage;
	//文本页数
	public GameObject[] pages;

	int index = 0;

	void Start()
	{
		btn_nextpage.onClick.AddListener(Nextpage);
		btn_previouspage.onClick.AddListener(Previouspage);
		SetFalseTrue();
	}

	private void Previouspage()
	{
		int index1 = index - 1;
		pages[index].SetActive(false);
		pages[index1].SetActive(true);
		index--;
		SetFalseTrue();
	}

	void Nextpage()
	{
		int index1 = index + 1;
		pages[index].SetActive(false);
		pages[index1].SetActive(true);
		index++;
		SetFalseTrue();
	}

	public void SetFalseTrue()
	{
		if (index == 0)
		{
			btn_previouspage.gameObject.SetActive(false);
			btn_nextpage.gameObject.SetActive(true);
		}
		else if (index == pages.Length - 1)
		{
			btn_previouspage.gameObject.SetActive(true);
			btn_nextpage.gameObject.SetActive(false);
		}
		else
		{
			btn_previouspage.gameObject.SetActive(true);
			btn_nextpage.gameObject.SetActive(true);
		}
	}

}
