using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerAudio : MonoBehaviour , IPointerEnterHandler
{
    private AudioSource sound01;

    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        sound01.PlayOneShot(sound01.clip);
    }
}