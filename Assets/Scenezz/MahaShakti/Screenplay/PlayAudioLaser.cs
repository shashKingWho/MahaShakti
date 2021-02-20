using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioLaser : MonoBehaviour
{
    public AudioSource pela;
    public List<AudioClip> laserKiAudio;
    // Start is called before the first frame update
    void Start()
    {
        pela = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaserStart(int indexNo)
    {
        pela.clip = laserKiAudio[indexNo];
        pela.Play();
        Debug.Log(GetComponent<AudioSource>().clip);
    }

    public void LaserBand(int indexNo) {
        pela.clip = laserKiAudio[indexNo];
        pela.Play();
        Debug.Log(GetComponent<AudioSource>().clip);
    }
}
