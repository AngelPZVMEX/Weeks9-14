using UnityEngine;
using UnityEngine.InputSystem;

public class controllerinput : MonoBehaviour
{

    public float speed = 5;
    public Vector2 movement;
    public AudioSource sfx;
    public Component knife;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;

        //transform.position = movement;
        knife.transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack" + context.phase);
        if (context.performed == true)
        {
            sfx.Play();
        }

    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        //same as mouse.current.position.readvalue()
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}
