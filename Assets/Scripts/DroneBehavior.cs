using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBehavior : MonoBehaviour
{
    public bool isLanded=false;
    public float speedy = 360.0f;

    [SerializeField]
    private List<GameObject> Fans;
    [SerializeField]
    private GameObject Lidar;

    Animator playerAnim;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLanded)
        {
            playerAnim.SetBool("HandleRightOpen", true);
            playerAnim.SetBool("HandleLeftOpen", true);
            playerAnim.SetBool("HandleRightClosed", false);
            playerAnim.SetBool("HandleLeftClosed", false);

            playerAnim.SetBool("BatteryCoverOpen", true);
            playerAnim.SetBool("BatteryCoverClose", false);

            playerAnim.SetBool("RemoveBattery", true);
            playerAnim.SetBool("InsertBattery", false);
        }
        else
        {
            for (int i = 0; i < Fans.Count; i++)
            {
                Vector3 Rotation = new Vector3(0, 0, speedy);
                Fans[i].transform.Rotate(Rotation * Time.deltaTime);
            }
            Vector3 LidarRotation = new Vector3(0, speedy, 0);
            Lidar.transform.Rotate(LidarRotation * Time.deltaTime);


            playerAnim.SetBool("HandleRightOpen", false);
            playerAnim.SetBool("HandleLeftOpen", false);
            playerAnim.SetBool("HandleRightClosed", true);
            playerAnim.SetBool("HandleLeftClosed", true);

            playerAnim.SetBool("BatteryCoverClose", true);
            playerAnim.SetBool("BatteryCoverOpen", false);

            playerAnim.SetBool("InsertBattery", true);
            playerAnim.SetBool("RemoveBattery", false);

        }
        
    }
}
