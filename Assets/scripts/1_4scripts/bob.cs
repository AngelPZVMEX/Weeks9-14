using Unity.VisualScripting;
using UnityEngine;

public class bob : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public Vector2 hold;

    public float t = 0;
    public float speed = 0.001f;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += speed;

        if (t > 1)
        {
            t = 0;
            hold = start.position;
   start.position = end.position;
            end.position = hold;
         
        }

        transform.position = Vector2.Lerp(start.position,end.position,curve.Evaluate(t));
    }
}
