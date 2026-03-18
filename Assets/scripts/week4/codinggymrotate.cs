using UnityEngine;

public class codinggymrotate : MonoBehaviour
{

   public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotate = transform.eulerAngles;
        Rotate.z += speed * Time.deltaTime;
        transform.eulerAngles = Rotate;
    }

    public void GoFast()
    {
        speed = 100;
    }

    public void NoFast ()
    {
        speed = 0;
    }
}
