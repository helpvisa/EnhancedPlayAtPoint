using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipTester : MonoBehaviour
{
    void Update()
    {
        if (triggerAudio)
        {
            triggerAudio = false;
            PlayAtPoint.PlayClip(audioClip, transform.position, 1f, 1f, true);
        }
    }

    [SerializeField] AudioClip audioClip;
    public bool triggerAudio = false;
}
