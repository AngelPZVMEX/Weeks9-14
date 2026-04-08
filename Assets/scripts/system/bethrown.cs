using System.Collections;
using UnityEngine;

public class bethrown : MonoBehaviour
{
    public Transform start;
    public Transform glove;
    public float t = 0;

    public Transform balltransform;
    public AnimationCurve curve ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        balltransform.localScale = Vector2.one;
    }

    // Update is called once per frame
    void Update()
    {
      

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
           
            balltransform.localScale = Vector2.one * (t / 10);
            balltransform.position = Vector2.Lerp(start.position, glove.position, curve.Evaluate(t));
            Debug.Log("throw");
            yield return null;
        }
       
    }
}
