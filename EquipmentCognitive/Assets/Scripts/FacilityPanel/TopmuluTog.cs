using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopmuluTog : MonoBehaviour
{
	GameObject modeCan;
	GameObject kuang;

	void Start()
	{
		modeCan = GameObject.Find("ModeCanvas");
		kuang = GameObject.Find("FacilityIntroducePanel/Bg/kuang");
		gameObject.GetComponent<Toggle>().onValueChanged.AddListener(TogFF);
	}

	private void TogFF(bool arg0)
	{
		if (arg0 == true)
		{
			for (int i = 0; i < modeCan.transform.childCount; i++)
			{
				modeCan.transform.GetChild(i).gameObject.SetActive(false);
			}
			modeCan.transform.Find(transform.name).gameObject.SetActive(true);

			for (int i = 0; i < kuang.transform.childCount; i++)
			{
				kuang.transform.GetChild(i).gameObject.SetActive(false);
			}
			kuang.transform.Find(transform.name).gameObject.SetActive(true);
		}
	}

	void Update()
	{

	}
}
