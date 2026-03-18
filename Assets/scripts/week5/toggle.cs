using UnityEngine;

public class toggle : MonoBehaviour
{
    public void toggleBird()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        ////ifgame object is active: turn ogg and other way around
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}

        //if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}
    }
}
