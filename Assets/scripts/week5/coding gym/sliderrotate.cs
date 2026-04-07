using UnityEngine;
using UnityEngine.UI;

public class sliderrotate : MonoBehaviour
{
    public float rotate = 0;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 Rotate = transform.eulerAngles;
        Rotate.z = slider.value;
        transform.eulerAngles = Rotate;
    }
}
