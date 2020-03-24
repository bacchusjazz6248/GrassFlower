using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LongFadeOutInContinue : MonoBehaviour {
    public GameObject Panel;
    float a;
    private AudioSource bgm;

    void Start () 
    {
        a = Panel.GetComponent<Image>().color.a;
        bgm = GameObject.Find ("Main Camera").GetComponent<AudioSource>();
    }
    
    public void OnClickInStart () {
        StartCoroutine(FadePanel());
    }

    //フェードアウト自体は↓の処理
    IEnumerator FadePanel()
    {
        while (a < 1)
        {
            Panel.GetComponent<Image>().color += new Color(0, 0, 0, 0.01f);
            a += 0.01f;
            bgm.volume -= 0.01f;
            yield return null;
        }
        SceneManager.LoadScene(PlayerPrefs.GetString("CurrentSceneData"));
    }
}