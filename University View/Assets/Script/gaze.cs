using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaze : MonoBehaviour
{
    
    public GameObject camera_rig;
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    // Start is called before the first frame update
    void Start()
    {
        camera_rig.transform.Rotate(0, 45, 0);
        imgGaze.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

    }

    public void next_image()
    {

    }
    public void GVRon()
    {
        gvrStatus = true;
    }
    public void GVRoff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
