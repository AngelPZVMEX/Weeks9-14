using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class glove : MonoBehaviour
{
    public float speed = 3; // sets sppeed of glove
    public Vector2 movement;

    public SpriteRenderer button;
    public bool isinButton = false;
    public UnityEvent onButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += (Vector3)movement * speed * Time.deltaTime; //updates position of glove

        if (button.bounds.Contains(transform.position) == true) //is glove in button?
        {
            if (isinButton == true) //in button
            {

            }
            else
            { //just entered button
                isinButton = true;
                onButton.Invoke();
            }

        }
        else
        { //leftbutton

            isinButton = false;
        }
    }

    public void OnMoveGlove(InputAction.CallbackContext context)  //gets unity input manager to calculate movement so we can add it to the position in update
    {
        movement = context.ReadValue<Vector2>();
    }

}
