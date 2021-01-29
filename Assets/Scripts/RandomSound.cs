using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    [SerializeField]
    Vector2 pitchRange = new Vector2();

    [SerializeField]
    Vector2 volumeRange = new Vector2();

    [SerializeField]
    List<AudioClip> clips = new List<AudioClip>();

    [SerializeField]
    AudioSource source = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlayRandomSound()
    {
        int index = Random.Range(0, clips.Count);
        float volume = Random.Range(volumeRange.x, volumeRange.y);
        float pitch = Random.Range(pitchRange.x, pitchRange.y);
        var clip = clips[index];
        source.pitch = pitch;
        source.PlayOneShot(clip, volume);
    }
}
