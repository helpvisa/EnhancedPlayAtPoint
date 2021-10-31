using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOccluder : MonoBehaviour
{
    void Start()
    {
        lowPass = this.gameObject.AddComponent<AudioLowPassFilter>();
        lowPass.lowpassResonanceQ = 1;
        lowPass.cutoffFrequency = 22000;

        audioSource = GetComponent<AudioSource>();
        initialVolume = audioSource.volume;
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (player != null && audioSource != null && performOcclusion)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, player.transform.position - transform.position, out hit, audioSource.maxDistance))
            {
                if (hit.collider.gameObject != player.transform.gameObject)
                {
                    lowPass.cutoffFrequency = Mathf.Lerp(lowPass.cutoffFrequency, lowPassRolloff, Time.deltaTime * rolloffSpeedMultiplier);
                    audioSource.volume = Mathf.Lerp(audioSource.volume, initialVolume / loweredVolumeFactor, Time.deltaTime * rolloffSpeedMultiplier);
                }
                else
                {
                    lowPass.cutoffFrequency = Mathf.Lerp(lowPass.cutoffFrequency, 22000, Time.deltaTime * rolloffSpeedMultiplier);
                    audioSource.volume = Mathf.Lerp(audioSource.volume, initialVolume, Time.deltaTime * rolloffSpeedMultiplier);
                }
            }
        }
    }

    // components
    AudioLowPassFilter lowPass;
    AudioSource audioSource;
    PlayerController player;

    // variables
    public float lowPassRolloff = 1000;
    public float loweredVolumeFactor = 2;
    public float rolloffSpeedMultiplier = 10;
    public bool performOcclusion = true;
    float initialVolume = 0f;
}
