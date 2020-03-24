﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDPage1 : MonoBehaviour {
	
	GameObject page2, text1, text2;
	private AudioSource sound01;
	void Start()
	{
		this.page2= GameObject.Find("page2");
		this.text1= GameObject.Find("Yes");
		this.text2= GameObject.Find("No");
		page2.GetComponent<Text>().enabled = false;
		text1.GetComponent<Text>().enabled = false;
		text2.GetComponent<Text>().enabled = false;
		sound01 = GetComponent<AudioSource>();
	}
	public void Destroy(){
		sound01.PlayOneShot(sound01.clip);
		Destroy(this.gameObject);
		page2.GetComponent<Text>().enabled = true;
		text1.GetComponent<Text>().enabled = true;
		text2.GetComponent<Text>().enabled = true;
	}
}
