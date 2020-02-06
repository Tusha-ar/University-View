using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateToAddmission : MonoBehaviour
{
    public gaze obj;
    public GameObject camera_rig;
    public GameObject gateToAdd;
    public Vector3 rotate;
    public AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obj.imgGaze.fillAmount == 1)
        {
            camera_rig.transform.position = gateToAdd.transform.position;
            camera_rig.transform.Rotate(rotate,Space.Self);
            Invoke("play_audio", 0.5f);
        }
    }
    void play_audio()
    {
        AudioSource.PlayClipAtPoint(audio, camera_rig.transform.position);
    }
}
