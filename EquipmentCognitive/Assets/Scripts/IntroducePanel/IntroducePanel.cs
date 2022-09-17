using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroducePanel : MonoBehaviour
{
	public GameObject Smallframe;
	public GameObject Smallframe2;
	string Panelname;
	GameObject modeCan;
	public GameObject facilityIntroducePanel;
	public int index = 1;
	private void Start()
	{
		modeCan = GameObject.Find("ModeCanvas");
		SmallfromGetToggle();
	}
	private void SmallfromGetToggle()
	{
		for (int i = 0; i < Smallframe.transform.childCount; i++)
		{
			Smallframe.transform.GetChild(i).GetComponent<Toggle>().onValueChanged.AddListener(Show);
		}
		for (int i = 0; i < Smallframe2.transform.childCount; i++)
		{
			Smallframe2.transform.GetChild(i).GetComponent<Toggle>().onValueChanged.AddListener(Show2);
		}
	}
	private void Show(bool arg0)
	{
		SmallfromShow(Smallframe, index = 0);
	}
	private void Show2(bool arg0)
	{
		SmallfromShow(Smallframe2, index = 1);
	}
	private void SmallfromShow(GameObject Smallframe, int index)
	{
		for (int i = 0; i < Smallframe.transform.childCount; i++)
		{
			if (Smallframe.transform.GetChild(i).GetComponent<Toggle>().isOn)
			{
				Panelname = Smallframe.transform.GetChild(i).name;
			}
		}
		modeCan.transform.Find(Panelname).gameObject.SetActive(true);
		facilityIntroducePanel.transform.Find("Bg/kuang").transform.Find(Panelname).gameObject.SetActive(true);
		facilityIntroducePanel.transform.Find("Bg/topmulu").transform.Find(Panelname).GetComponent<Toggle>().isOn = true;
		facilityIntroducePanel.SetActive(true);
		CatalogueCut();
	}
	public void CatalogueCut()
	{
		if (index == 0)
		{
			TopmuluManager._Instance.Previouspage();
		}
		else
		{
			TopmuluManager._Instance.Nextpage();
		}
	}
}
