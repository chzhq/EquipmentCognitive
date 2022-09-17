using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FacilityIntroduceUI : MonoBehaviour
{
	public Button btn_back;
	public Button btn_home;
	public Button btn_exit;
	public GameObject IntroducePanel;
	public GameObject HomepagePanel;
	List<Vector3> modepos = new List<Vector3>();
	GameObject modeCan;
	void OnEnable()
	{
		modepos.Clear();
		modeCan = GameObject.Find("ModeCanvas");
		for (int i = 0; i < modeCan.transform.childCount - 1; i++)
		{
			modepos.Add(modeCan.transform.GetChild(i).transform.eulerAngles);
		}

	}
    private void Start()
    {
		btn_back.onClick.AddListener(Back);
		btn_home.onClick.AddListener(GoHome);
		btn_exit.onClick.AddListener(ExitGame);
	}
    void Back()
	{
		gameObject.SetActive(false);

		IntroducePanel.SetActive(true);
		ModeHide();
	}
	void GoHome()
	{
		gameObject.SetActive(false);
		HomepagePanel.SetActive(true);
		ModeHide();
	}
	void ModeHide()
	{
		for (int i = 0; i < modeCan.transform.childCount - 1; i++)
		{
			modeCan.transform.GetChild(i).transform.eulerAngles = modepos[i];
			modeCan.transform.GetChild(i).gameObject.SetActive(false);
		}
		for (int i = 0; i < this.transform.Find("Bg/kuang").transform.childCount; i++)
		{
			if (this.transform.Find("Bg/kuang").transform.GetChild(i).gameObject.activeSelf)
			{
				this.transform.Find("Bg/kuang").transform.GetChild(i).gameObject.SetActive(false);
			}
		}
		for (int i = 0; i < this.transform.Find("Bg/kuang").transform.childCount; i++)
		{
			this.transform.Find("Bg/topmulu").transform.GetChild(i).GetComponent<Toggle>().isOn = false;
		}
	}
	public void ExitGame()
	{
		////预处理
		//       #if UNITY_EDITOR    //在编辑器模式下
		// EditorApplication.isPlaying = false;
		//       #else
		//       Application.Quit();
		//       #endif
		Debug.Log("554545454");
		Application.Quit();
	}
	// Update is called once per frame
	void Update()
	{

	}
}
