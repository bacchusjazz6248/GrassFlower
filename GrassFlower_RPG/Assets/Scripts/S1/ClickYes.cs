using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickYes : MonoBehaviour {
	
    GameObject text1, text2, text3, page2;
    void Start()
    {
        this.text1= GameObject.Find("Yes");
        this.text2= GameObject.Find("No");
        this.text3= GameObject.Find("Save");
        this.page2= GameObject.Find("page2");
        text3.GetComponent<Text>().enabled = false;
    }
    public void SaveData(){
        PlayerPrefs.SetString("CurrentSceneData","Scene2");
        Destroy(this.text1);
        Destroy(this.text2);
        Destroy(this.page2);
        text3.GetComponent<Text>().enabled = true;
    }
}