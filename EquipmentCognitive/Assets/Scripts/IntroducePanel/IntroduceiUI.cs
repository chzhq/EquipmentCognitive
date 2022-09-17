using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroduceiUI : MonoBehaviour
{
	public Toggle toggle_1;
	public Toggle toggle_2;
	GameObject Smallframe;
	GameObject Smallframe2;
	void Start()
	{
		Smallframe = transform.Find("Bg/Smallframe").gameObject;
		Smallframe2 = transform.Find("Bg/Smallframe2").gameObject;
		toggle_1.onValueChanged.AddListener(ShowHide);
		toggle_2.onValueChanged.AddListener(ShowHide2);

	}

	private void ShowHide(bool arg0)
	{
		if (toggle_1.isOn)
		{
			Smallframe.SetActive(false);
			Smallframe2.SetActive(true);
		}
	}
	private void ShowHide2(bool arg0)
	{
		if (toggle_2.isOn)
		{
			Smallframe2.SetActive(false);
			Smallframe.SetActive(true);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
