using UnityEngine;

public static class PlayAtPoint
{
    public static AudioSource PlayClip(AudioClip clip, Vector3 position, float volume, float pitch, bool occludeAudio, bool follow, Transform target)
    {
        GameObject newClipObject = new GameObject();
        newClipObject.name = "Point_Clip";
        newClipObject.transform.position = position;
        AudioSource audioSource = newClipObject.AddComponent<AudioSource>();
        newClipObject.AddComponent<AudioOccluder>();
        newClipObject.GetComponent<AudioOccluder>().performOcclusion = occludeAudio;
        newClipObject.AddComponent<ClipDestructor>();
        newClipObject.GetComponent<ClipDestructor>().followForDuration = follow;
        newClipObject.GetComponent<ClipDestructor>().target = target;
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.pitch = pitch;
        audioSource.spatialBlend = 1;
        audioSource.Play();

        return audioSource;
    }
    
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

    public static AudioSource PlayClip(AudioClip clip, Vector3 position, float volume, float pitch)
    {
        GameObject newClipObject = new GameObject();
        newClipObject.name = "Point_Clip";
        newClipObject.transform.position = position;
        AudioSource audioSource = newClipObject.AddComponent<AudioSource>();
        newClipObject.AddComponent<AudioOccluder>();
        newClipObject.GetComponent<AudioOccluder>().performOcclusion = true;
        newClipObject.AddComponent<ClipDestructor>();
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.pitch = pitch;
        audioSource.spatialBlend = 1;
        audioSource.Play();

        return audioSource;
    }

    public static AudioSource PlayClip(AudioClip clip, Vector3 position, float volume)
    {
        GameObject newClipObject = new GameObject();
        newClipObject.name = "Point_Clip";
        newClipObject.transform.position = position;
        AudioSource audioSource = newClipObject.AddComponent<AudioSource>();
        newClipObject.AddComponent<AudioOccluder>();
        newClipObject.GetComponent<AudioOccluder>().performOcclusion = true;
        newClipObject.AddComponent<ClipDestructor>();
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.pitch = 1;
        audioSource.spatialBlend = 1;
        audioSource.Play();

        return audioSource;
    }
}
