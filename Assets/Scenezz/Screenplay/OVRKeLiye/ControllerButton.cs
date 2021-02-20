using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButton : MonoBehaviour
{
    //public GameObject leftTriggerObj, rightTriggerObj;
    public PlayAudio playAudio;


    //public OVRInput.Controller leftHillaNa, rightHillaNa;
    public HapticsOHYeah hapticsOHYeah;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch)) { 
      
            hapticsOHYeah.Vibrator(.03f, .4f, .3f, OVRInput.Controller.RTouch);
            playAudio.BajaBajaaa();
        
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {

            hapticsOHYeah.Vibrator(.03f, .4f, .3f, OVRInput.Controller.LTouch);
            playAudio.BajaBajaaa();

        }

        //if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        //{
        //    hapticsOHYeah.Vibrator(.03f, .4f, .3f, OVRInput.Controller.LTouch);
        //    playAudio.BajaBajaaa();
            
        //}

    }
}
