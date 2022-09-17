using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllModeRotate : MonoBehaviour
{
	private bool roate;
	private float RoatedSpeed = 1000.0f;
	void Start()
	{
		roate = false;
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			float speed = 2.5f;//旋转跟随速度
			float OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
			float OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量
			transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed, Space.World);//旋转物体
		}

	}

}
