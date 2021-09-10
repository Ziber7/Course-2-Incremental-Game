using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume;

    public void OnPointerDown (PointerEventData eventData)
    {
        audioSource.PlayOneShot(clip, volume);
        GameManager.Instance.CollectByTap (eventData.position, transform);
    }
}
