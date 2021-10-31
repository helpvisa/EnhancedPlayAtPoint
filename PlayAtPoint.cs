using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayAtPoint
{
    public static AudioSource PlayClip(AudioClip clip, Vector3 position, float volume, float pitch, bool occludeAudio)
    {
        GameObject newClipObject = new GameObject();
        newClipObject.name = "Point_Clip";
        newClipObject.transform.position = position;
        AudioSource audioSource = newClipObject.AddComponent<AudioSource>();
        newClipObject.AddComponent<AudioOccluder>();
        newClipObject.GetComponent<AudioOccluder>().performOcclusion = occludeAudio;
        newClipObject.AddComponent<ClipDestructor>();
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.pitch = pitch;
        audioSource.spatialBlend = 1;
        audioSource.Play();

        return audioSource;
    }
}
