using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class eyetrack : MonoBehaviour
{

    public float t = 0;
    public AnimationCurve curve;
    public Vector2 mousePos;

    public Vector2 start;

    public Vector2 end;

    public Vector2 middle;

   float offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        start = transform.position;
        middle = transform.position;
        offset = .13f;
    }

    // Update is called once per frame
    void Update()
    {
 // using the mouse position evaluate how to move the eye
        if (mousePos.x > 0)
        {
            end.x = middle.x + offset;
        }
        else if (mousePos.x < 0)
        {
            end.x = middle.x - offset;
        }

        if (mousePos.y > 0)
        {
            end.y = middle.y + offset;
        }
        else if (mousePos.y < 0)
        {
            end.y = middle.y - offset;
        }
        //find mouse position
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        t += Time.deltaTime;

       
        if (t > 1)
        {
            t = 0;

            start = transform.position;
           
        }
        transform.position = Vector2.Lerp(start, end, t);

    }
}
