using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class clicktomove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       


        //was the button presses this frame?&&& not on button
      if (  Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
        {
           Vector2 mousePOS = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePOS;
        }
        //Y set position to mouse position

    }
}
