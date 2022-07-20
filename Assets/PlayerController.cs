using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource source;

    public AudioClip[] audioList;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayAudio(int index)
    {
        source.clip = audioList[index];
        source.Play();
    }
}
