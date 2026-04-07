using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class spritechanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List <Sprite>  barrels;
 
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Pickarandomcolor();
       PickARandomSprite();
    
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("try to change the prite");
            //     Pickarandomcolor();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over sprite?
       if(spriteRenderer.bounds.Contains(mousePos))
        {
//y: use col var
spriteRenderer.color = col;
        }
        else
        {
 //n set to white
 spriteRenderer.color=Color.white;
        }
        
      if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count >0 )
        {

            barrels.RemoveAt(0);
        }
       

    }

    void Pickarandomcolor()
    {
 spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number 0-2
        randomNumber = Random.Range(0, barrels.Count);

        spriteRenderer.sprite = barrels[randomNumber];
    }
}
