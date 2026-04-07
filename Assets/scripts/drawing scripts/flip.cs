using UnityEngine;
using UnityEngine.InputSystem;

public class flip : MonoBehaviour
{
    public Vector2 xscale;
    public Vector2 mousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gives it starting scale
        xscale.y = 0.4f;
        xscale.x = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        //find the mouse position on screen and give it to a variable
         mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //if mouse position is in -x  and scale is negative, flip

        //if mouse is in positive x and scale is positive flip
        if (mousePos.x > 0 && transform.localScale.x < 0)
        {
            xscale = transform.localScale;
            xscale.x = xscale.x * -1;
            transform.localScale = xscale;
        }
        else if (mousePos.x < 0 && xscale.x > -0)
        {
            xscale = transform.localScale;
            xscale.x = xscale.x * -1;
            transform.localScale = xscale;
        }


    }
}
