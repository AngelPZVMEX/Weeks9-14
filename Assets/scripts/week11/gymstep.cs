

using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;


public class gymstep : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<AudioClip> sounds;
    public AudioSource source;
    public int rand;
    Vector2 knightpos;
    float speed = .02f;
    public CinemachineImpulseSource impulsesource;


    void Start()
    {
        knightpos.x = 0;
        knightpos.y = -3;
        transform.position = knightpos;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 32)
        {
            knightpos.x += speed;
            transform.position = knightpos;
        }
    }

    public void footsteps()
    {
        rand = (Random.Range(0, sounds.Count));

        source.PlayOneShot(sounds[rand]);
        impulsesource.GenerateImpulse();
    }
}
