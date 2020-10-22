using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip music;
    public AudioSource victorySFX;
    public AudioSource footSteps;

    public AudioClip[] footStepsVariation;

    [Header("Randomize Pitch Settings")]

    [Range(1f, 1.5f)]
    public float maxPitch = 1.0f;
    [Range(0.5f, 1f)]
    public float minPitch = 1.0f;

    [Header("Randomize Volume Settings")]

    [Range(0f, 1f)]
    public float maxVolume = 1.0f;
    [Range(0f, 1f)]
    public float minVolume = 1.0f;

    private int lastSound;
    private static SoundManager instance = null;
    public static SoundManager sharedInstance
    {

        //Accesseur automatique
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<SoundManager>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Victory()
    {
        victorySFX.Play();
    }

    public void FootSteps()
    {
        int soundID = Random.Range(0, footStepsVariation.Length);

        while (soundID == lastSound)
        {
            soundID = Random.Range(0, footStepsVariation.Length);
        }

        footSteps.clip = footStepsVariation[soundID];

        footSteps.volume = Random.Range(minVolume, maxVolume);

        footSteps.pitch = Random.Range(minPitch, maxPitch);

        lastSound = soundID;

        footSteps.Play();
    }
}
