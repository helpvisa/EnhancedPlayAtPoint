using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipDestructor : MonoBehaviour
{
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Destroy(audioSource.gameObject, audioSource.clip.length);
    }
}
