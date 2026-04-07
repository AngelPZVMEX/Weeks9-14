using UnityEngine;
using UnityEngine.InputSystem;

public class randomcolor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pickarandomcolor();

    }

    // Update is called once per frame
    void Update()
    {



     
       

    }

    public void Pickarandomcolor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}