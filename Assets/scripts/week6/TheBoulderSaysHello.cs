using UnityEngine;
using UnityEngine.Events;

public class TheBoulderSaysHello : MonoBehaviour
{
    public float time;
    public SpriteRenderer Lara;
    public SpriteRenderer boulder;
    public float speed;
    public Vector2 target;
    public Vector2 start;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
        time = 0;
        Lara.transform.position = target;
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


        if(time >= 7 )
        {
            Destroy( boulder );
        }
       transform.position= Vector2.Lerp(start, target,time);
    }
}
