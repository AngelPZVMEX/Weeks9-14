using UnityEngine;
using UnityEngine.Events;

public class contactsensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;

    void Start()
    {
        
    }

  
    void Update()
    {
        
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true)
            {
                //was already in hazard
            }
            else
            {
                //entered
                //go!
                //we in hazard
                Debug.Log("entered");
                OnEnterSensor.Invoke();
                isInHazard = true;
            }

              
        }
        else
        {
            if (isInHazard == true)
            {
                //we left
                //go!
                Debug.Log("left the sensor");
                OnExitSensor.Invoke();  
                isInHazard = false ;
                OnRandomNumber.Invoke(Random.Range(0,10));
            }
           else
            {
                //its always been false
            }
        }
    }

    public void ShowNumber (float number)
    {
        Debug.Log(number);
    }
}
