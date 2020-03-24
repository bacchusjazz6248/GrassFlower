using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour {

    private AudioSource sound01;

    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }
    /// ボタンをクリックした時の処理
    public void OnClickStart() {
        sound01.PlayOneShot(sound01.clip);
    }
    
    public void OnClickContinue() {
        sound01.PlayOneShot(sound01.clip);
    }
    
    public void OnClickExit() {
        sound01.PlayOneShot(sound01.clip);
        UnityEngine.Application.Quit();
    }
}