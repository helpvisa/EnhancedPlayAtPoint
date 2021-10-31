using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipDestructor : MonoBehaviour
{
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Destroy(audioSource.gameObject, audioSource.clip.length);

        if (target != null)
        {
            offset = target.position - transform.position;
        }
    }

    void Update()
    {
        if (followForDuration && target != null)
        {
            transform.position = target.position - offset;
        }
    }

    // variables
    public bool followForDuration = false;
    public Transform target;
    Vector3 offset = new Vector3(0,0,0);
}
