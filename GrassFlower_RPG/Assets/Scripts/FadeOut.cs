using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {
    public GameObject Panel;
    float a;

    void Start () 
    {
        a = Panel.GetComponent<Image>().color.a;
    }

    //Aキーを押されたらフェード開始
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
    }
}