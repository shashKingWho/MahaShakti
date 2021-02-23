using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistOfFury : MonoBehaviour
{
    AudioSource bajaa;
    public OVRInput.Controller controllerBataChal;

    public HapticsOHYeah hapticsOHYeah;
    public MeshRenderer meshy;

    // Start is called before the first frame update
    void Start()
    {
        Find_Audio();
    }

    // Update is called once per frame
    void Update()
    {
        if (bajaa == null) {
            Find_Audio();
        }
        if (meshy == null) {
            Find_Meshy();
            Debug.Log(meshy + " idhar yeh he BHSSSSSSSSSS");
        }
        if (hapticsOHYeah == null)
        {
            Find_HapticsOhYeah();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemyThick")) {
            bajaa.Play();
            //other.enabled = false;
        }
    }

    void Find_Audio()
    {
        bajaa = GetComponent<AudioSource>();
    }

    public void FistOFDoom()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controllerBataChal)) //OVRInput.Button.One, ))
        {
            hapticsOHYeah.Vibrator(.03f, .4f, .3f, controllerBataChal);
            //StartCoroutine(VisiblePower());
            meshy.enabled = true;
        }
    }

    void Find_Meshy() {
        meshy = GetComponent<MeshRenderer>();
    }

    IEnumerator VisiblePower() { 
        meshy.enabled = true;
        yield return new WaitForSeconds(1f);
        meshy.enabled = false;
    }

    void Find_HapticsOhYeah()
    {
        hapticsOHYeah = GameObject.Find("HapticsOHYeah").GetComponent<HapticsOHYeah>();
    }
}
