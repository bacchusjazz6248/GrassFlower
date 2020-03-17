using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInText : MonoBehaviour {
    public GameObject Text;
    float a;

    void Start () 
    {
        a = 0.0f;
    }

    void Update () 
    {
        StartCoroutine(FadeText());
    }

    //フェードアウト自体は↓の処理
    IEnumerator FadeText()
    {
        while (a < 255)
        {
            a += 0.01f;
            Text.GetComponent<Text>().color = new Color(0, 0, 0, a);
            yield return null;
        }
    }
    
    
}