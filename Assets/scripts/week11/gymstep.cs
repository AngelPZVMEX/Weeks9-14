

using System.Collections.Generic;
using UnityEngine;

public class gymstep : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<AudioClip> sounds;
    public AudioSource source;
    public int rand;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void footsteps()
    {
        rand = (Random.Range(0, sounds.Count));

        source.PlayOneShot(sounds[rand]);

    }
}
