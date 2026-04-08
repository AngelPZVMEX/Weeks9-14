using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class localmanager : MonoBehaviour
{

    public List<Sprite> playersprites;
    public List<PlayerInput> players;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerJoin(PlayerInput player)
    {
        players.Add(player);

        SpriteRenderer sr = player.GetComponent<SpriteRenderer>();
        sr.sprite = playersprites[player.playerIndex];

        localmultiplayercontroller controller = player.GetComponent<localmultiplayercontroller>();
        controller.manager = this;
    }

    public void PlayerAttacking(PlayerInput attackingPLayer)
    {
        
        for ( int i = 0; i < players.Count; i++ )
        {
            localmultiplayercontroller controller = players[i].GetComponent<localmultiplayercontroller>();
            if (attackingPLayer == players[i]) continue;
           

            
          if(  Vector2.Distance(attackingPLayer.transform.position, players[i].transform.position) < 0.5)
            {
                Debug.Log("Player " + attackingPLayer.playerIndex + "hit player " + players[i].playerIndex);
                controller.takeDamage();
            }

        }
        
    }
}
