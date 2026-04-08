using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class localmultiplayercontroller : MonoBehaviour
{
    public localmanager manager;
    public PlayerInput playerInput;
    public Vector2 moveInput;
    public float speed = 5;

    public float health = 5;
    public Boolean isDead = false;
    public SpriteRenderer spriteRenderer;
    public Color color;
    void Start()
    {
        color = spriteRenderer.color;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDead = true;
            color.a = .5f;
            spriteRenderer.color = color;
        }
        else
        {
            isDead = false;
            color.a = 1;
            spriteRenderer.color = color;
        }
            transform.position += (Vector3)moveInput * speed * Time.deltaTime;
    }

    public void Onmove(InputAction.CallbackContext context)
    {
        if (isDead == false)
        
        moveInput = context.ReadValue<Vector2>();   
    }

    public void onAttack(InputAction.CallbackContext context)
    {
        if (isDead == false)
        {
            if (context.performed)
            {
                Debug.Log("PLayer " + playerInput.playerIndex + ": Attacking!");
                manager.PlayerAttacking(playerInput);
            }
        }


    }

    public void takeDamage()
    {
        health--;
    }

}
