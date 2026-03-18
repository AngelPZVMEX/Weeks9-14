using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class buildsite : MonoBehaviour
{

    public GameObject statue;
    public GameObject chest;
    public GameObject bench;

    Coroutine statuecoroutine;
    Coroutine chestcoroutine;
    Coroutine benchcoroutine;
    Coroutine buildroutine;

    void Start()
    {
        statue.transform.localScale = Vector2.zero;
       chest.transform.localScale = Vector2.zero;
       bench.transform.localScale = Vector2.zero;
    }
  //  public void PlaceBuild
  //  {
  //      buildroutine = StartCoroutine(build());


  //  }

  //IEnumerator build ()
  //  {
  //      yield return statuecoroutine = StartCoroutine(growstatue());
  //      yield return chestcoroutine = StartCoroutine(Growchest());
  //      yield return benchcoroutine = StartCoroutine (growbench());

  //  }
    IEnumerator growstatue()
    {
     
        statue.transform.localScale = Vector2.zero;
        chest.transform.localScale = Vector2.zero;
        bench.transform.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {

            t += Time.deltaTime;
            statue.transform.localScale = Vector2.one * t;
            yield return null;
        }
        
    }

    IEnumerator growbench()
    {
        
        statue.transform.localScale = Vector2.zero;
        chest.transform.localScale = Vector2.zero;
        bench.transform.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {

            t += Time.deltaTime;
           bench.transform.localScale = Vector2.one * t;
            yield return null;
        }
        
    }

    IEnumerator Growchest()
    {
       
        statue.transform.localScale = Vector2.zero;
        chest.transform.localScale = Vector2.zero;
        bench.transform.localScale = Vector2.zero;
        float t = 0;
        while (t < 1)
        {

            t += Time.deltaTime;
            chest.transform.localScale = Vector2.one * t;
            yield return null;
        }
       
    }
}
