using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHaathSeCTRL : MonoBehaviour
{
    //public GameObject leftTriggerObj, rightTriggerObj;
    public PlayAudioLaser playAudio;


    public OVRInput.Controller controllerHillaNa;
    public HapticsOHYeah hapticsOHYeah;

    [Header("Laser Padegi")]
    public GameObject laser;

    // Start is called before the first frame update
    void Start()
    {

        Find_HapticsOhYeah();
        Find_LaserWaale();
        Find_LaserStuff();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hapticsOHYeah== null) {
            Find_HapticsOhYeah();
        }
        if (playAudio == null)
        {
            Find_LaserWaale();
        }
        if (laser == null) {
            Find_LaserStuff();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LaserFreaky")) {
            hapticsOHYeah.Vibrator(.03f, .4f, .3f, controllerHillaNa);
            playAudio.LaserStart(0);
            laser.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playAudio.LaserBand(1);
   
        laser.SetActive(false);
    }

    void Find_HapticsOhYeah() {
        hapticsOHYeah = GameObject.Find("HapticsOHYeah").GetComponent<HapticsOHYeah>();
    }
    
    public void Find_LaserWaale()
    {
        playAudio = GameObject.Find("LaserWaale").GetComponent<PlayAudioLaser>();
    }

    public void Find_LaserStuff() {
        laser = GameObject.Find("LaserStuff");
    }


}
