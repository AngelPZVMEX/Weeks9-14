using UnityEngine;
using UnityEngine.InputSystem;

public class glove : MonoBehaviour
{
    public float speed = 3; // sets sppeed of glove
    public Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime; //updates position of glove
    }

    public void OnMoveGlove(InputAction.CallbackContext context)  //gets unity input manager to calculate movement so we can add it to the position in update
    {
      movement =  context.ReadValue<Vector2>(); 
    }

}
