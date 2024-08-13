using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DroneAltitudeSlider : MonoBehaviour
{
    [SerializeField]
    private GameObject drone;

    private Vector3 dronePostion;

    public void SetNewAltitude(float value)
    {
        drone.transform.position = new Vector3 (dronePostion.x, value, dronePostion.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        dronePostion = drone.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
