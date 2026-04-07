using UnityEngine;
using UnityEngine.InputSystem;

public class randomspawn : MonoBehaviour
{
    public GameObject piratefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
          
        }
    }

    void spawn () 
        {
        Instantiate(piratefab);
    }
}
