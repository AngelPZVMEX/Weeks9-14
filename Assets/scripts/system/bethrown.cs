using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class bethrown : MonoBehaviour
{
    public Transform start;
    public Transform glove;
    public float t = 0;
    public float p = 1;

    public Transform balltransform;
    public AnimationCurve curve ;
    public AnimationCurve fast;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }

  public void Changepitch()
    {
        p = p * -1;
    }

    public void launch()
    {
        StartCoroutine(hurl());
    }


    IEnumerator hurl ()
    {
         t = 0;
       while (t < 1)
        { 
            t += Time.deltaTime;
           
            balltransform.localScale = Vector2.one * t;
            if (p == 1)
            {
                balltransform.position = Vector2.Lerp(start.position, glove.position, curve.Evaluate(t));
            }
            else balltransform.position = Vector2.Lerp(start.position, glove.position, fast.Evaluate(t));
            Debug.Log("throw");
            yield return null;
        }
       
    }
}
