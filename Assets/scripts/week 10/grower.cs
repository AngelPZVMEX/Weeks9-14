using System.Collections;
using UnityEngine;

public class grower : MonoBehaviour
{

    public Transform tree;
    public Transform apple;

    Coroutine doTheGrowingCoroutine;
    Coroutine growtreecoroutine;
    Coroutine growapplecoroutine;
    void Start()
    {
        tree.localScale = Vector2.zero;
        apple.localScale = Vector2.zero;
    }

    public void StartTreeGrow()
    {
        if (doTheGrowingCoroutine != null)
        {
            StopCoroutine(doTheGrowingCoroutine);
        }
        if (growtreecoroutine != null)
        {
            StopCoroutine(growtreecoroutine);
        }

        if (growapplecoroutine != null)
        {
            StopCoroutine (growapplecoroutine);
        }

        doTheGrowingCoroutine = StartCoroutine(DoTheGrowing()); 

    }


    IEnumerator DoTheGrowing()
    {
        yield return growtreecoroutine = StartCoroutine(GrowTree());
        yield return growapplecoroutine = StartCoroutine(GrowApple());
    }

    IEnumerator GrowTree()
    {
        Debug.Log("started tree");
        tree.localScale = Vector2.zero;
        apple.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {

            t += Time.deltaTime;
            tree.localScale = Vector2.one * t;
            yield return null;
        }
        Debug.Log("stopped tree");
    }

    IEnumerator GrowApple()
    {
        Debug.Log("started apple");
        apple.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {

            t += Time.deltaTime;
            apple.localScale = Vector2.one * t;
            yield return null;
        }
        Debug.Log("stopped apple");
    }
}
