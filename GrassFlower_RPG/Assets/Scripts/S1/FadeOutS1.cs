using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutS1 : MonoBehaviour {
	public GameObject Panel;
	float a;

	void Start () 
	{
		this.Panel= GameObject.Find("Panel");
		a = Panel.GetComponent<Image>().color.a;
	}

	void Update () 
	{
		StartCoroutine(FadePanel());
	}

	//フェードアウト自体は↓の処理
	IEnumerator FadePanel()
	{
		yield return new WaitForSeconds(5);
		while(a < 1)
		{
			Panel.GetComponent<Image>().color += new Color(0, 0, 0, 0.01f);
			a += 0.01f;
			yield return null;
		}
		yield return new WaitForSeconds(1);
	}
    
    
}
