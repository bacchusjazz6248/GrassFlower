using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour {
    public GameObject Panel;
    float a;

    void Start () 
    {
        a = Panel.GetComponent<Image>().color.a;
    }

    void Update () 
    {
        StartCoroutine(FadePanel());
    }

    //フェードアウト自体は↓の処理
    IEnumerator FadePanel()
    {
        while (a > 0)
        {
            a -= 0.01f;
            Panel.GetComponent<Image>().color = new Color(255, 255, 255, a);
            yield return null;
        }
    }
    
    
}