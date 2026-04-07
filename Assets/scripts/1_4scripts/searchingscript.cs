using UnityEngine;

public class searchingscript : MonoBehaviour
{
    public float ar = 0;

    public Vector2 start;

    public Vector2 end;

    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;

        end.x = Random.Range(-ar, ar);
        end.y = Random.Range(-ar, ar);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;

            start = transform.position;

            end.x = Random.Range(-ar, ar);
            end.y = Random.Range(-ar, ar);
        }

        transform.position = Vector2.Lerp(start, end, t);
    }
}
