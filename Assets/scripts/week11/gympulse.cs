using UnityEngine;
using UnityEngine.UIElements;

public class gympulse : MonoBehaviour
{
    public float speed = 1;
    public AnimationCurve AnimationCurve;
    public Vector2  newpos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        newpos.x += speed;
       // newpos.y = AnimationCurve
        transform.position = newpos;
       
    }
}
