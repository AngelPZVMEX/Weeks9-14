using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class placesite : MonoBehaviour
{
    public GameObject building;
    Vector2 place;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Vector2 place = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            Instantiate(building,place,Quaternion.identity);
            

        }

    }
}
