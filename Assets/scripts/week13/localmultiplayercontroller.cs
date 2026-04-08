using UnityEngine;
using UnityEngine.InputSystem;

public class localmultiplayercontroller : MonoBehaviour
{
    public localmanager manager;
    public PlayerInput playerInput;
    public Vector2 moveInput;
    public float speed = 5;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)moveInput * speed * Time.deltaTime;
    }

    public void Onmove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();   
    }

    public void onAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("PLayer " + playerInput.playerIndex + ": Attacking!");
            manager.PlayerAttacking(playerInput);
        }
    }

}
