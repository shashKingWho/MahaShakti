using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    AudioSource pela;
    // Start is called before the first frame update
    void Start()
    {
        pela = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BajaBajaaa()
    {
        pela.Play();
        Debug.Log(GetComponent<AudioSource>().clip);
    }

    public void BajaBand() {
        pela.Stop();
    }
}
