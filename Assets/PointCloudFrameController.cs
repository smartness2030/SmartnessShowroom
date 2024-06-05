using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PointCloudFrameController : MonoBehaviour
{
    public Texture[] positionTextures;
    public Texture[] colorTextures;

    public VisualEffect pointCloud;

    int count;
    int current = 0;
    double time = 0.0;
    // Start is called before the first frame update
    void Start()
    {
        //pointCloud.SetTexture("PositionMap", positionTextures[1]);
        //pointCloud.SetTexture("ColorMap", colorTextures[1]);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        count = (int)time;
        if(count%2 != current)
        {
            current = count % 2; 
            pointCloud.SetTexture("PositionMap", positionTextures[count % 2]);
            pointCloud.SetTexture("ColorMap", colorTextures[count % 2]);
            pointCloud.Reinit();
        }
    }
}
