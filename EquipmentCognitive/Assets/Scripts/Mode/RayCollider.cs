using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCollider : MonoBehaviour
{
    public Image jieshao;
    GameObject nowObj;
    Text txt_jieshao;
    Vector3 nowPos;
    bool isFalse = false;
    private void Start()
    {
        txt_jieshao = jieshao.transform.Find("txt_jieshao").GetComponent<Text>();
    }
    void Update()
    {
        //鼠标是否点击到位置
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit,50))
            {
                nowObj = hit.transform.gameObject;
                if (nowObj.GetComponent<Outline>() == null)
                {
                    nowObj.AddComponent<Outline>();
                }
                nowObj.GetComponent<Outline>().OutlineWidth = 3;
                nowObj.GetComponent<Outline>().enabled = true;
                jieshao.transform.localPosition = Input.mousePosition - new Vector3(800, 550, 800);
                jieshao.gameObject.SetActive(true);
                txt_jieshao.text = hit.transform.name;
                nowPos = Input.mousePosition;
                isFalse = true;
            }
        }
        //移动位置后隐藏
        if (isFalse)
        {
            if (Mathf.Abs(Input.mousePosition.x - nowPos.x) > 5 || Mathf.Abs(Input.mousePosition.y - nowPos.y) > 5)
            {
                nowObj.GetComponent<Outline>().enabled = false;
                jieshao.gameObject.SetActive(false);
                isFalse = false;
            }
        }
    }
}
