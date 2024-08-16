using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DroneAltitudeSlider : MonoBehaviour
{
    [SerializeField]
    private GameObject drone;

    private Vector3 dronePostion;

    private DroneBehavior droneBehavior;

    public void SetNewAltitude(float value)
    {
        drone.transform.position = new Vector3 (dronePostion.x, value, dronePostion.z);

        if(value <= 1.7)
        {
            droneBehavior.isLanded = true;
            droneBehavior.speedy = 0f;
        }
        else if(value > 1.7 && value <= 1.9)
        {
            droneBehavior.isLanded = false;
            droneBehavior.speedy = 360f;
        }
        else if (value > 1.9 && value <= 2.3)
        {
            droneBehavior.isLanded = false;
            droneBehavior.speedy = 480f;
        }
        else
        {
            droneBehavior.isLanded = false;
            droneBehavior.speedy = 720f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        dronePostion = drone.transform.position;
        droneBehavior = drone.GetComponent<DroneBehavior>();
    }
}
