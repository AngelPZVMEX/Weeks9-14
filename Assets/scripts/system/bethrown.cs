using UnityEngine;

public class bethrown : MonoBehaviour
{
    public Transform start;
    public Transform glove;
    public float t = 0;

    public AnimationCurve curve ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, glove.position, curve.Evaluate(t));

    }

    public void hurl ()
    {
        //t += Time.deltaTime;
        //if (t > 0)
        //{
        //    t=0;
        //}

        //transform.position = Vector2.Lerp(start, glove.position, t);
    }
}
