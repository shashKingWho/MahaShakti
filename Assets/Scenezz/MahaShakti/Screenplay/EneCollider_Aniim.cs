using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneCollider_Aniim : MonoBehaviour
{
    public bool Maara_left, Maara_right, Maara_aage, Maara_Peeche;
    public EnemyAnimationCTRL enemyAnimationCTRL;

    //public BoxCollider meraColllider;

    public GameObject mainAsurParent;

    //public OVRInput.Controller leftHillaNa, rightHillaNa;
    public HapticsOHYeah hapticsOHYeah;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (meraColllider = null)
        //{
        //    Find_BoxCol();
        //}
        if (hapticsOHYeah == null)
        {
            Find_HapticsOhYeah();

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightHook") || other.gameObject.CompareTag("LeftHook"))
        {
            
            if (Maara_right)
            {
                enemyAnimationCTRL.Maara_right = true;
            }
            if (Maara_left)
            {
                enemyAnimationCTRL.Maara_left = true;
            }
            if (Maara_aage)
            {
                enemyAnimationCTRL.Maara_aage = true;
            }

            if (Maara_Peeche)
            {
                enemyAnimationCTRL.Maara_Peeche = true;
            }
            if (other.gameObject.CompareTag("RightHook")) {
                hapticsOHYeah.Vibrator(.03f, .4f, .3f, OVRInput.Controller.RTouch);
            }
            if (other.gameObject.CompareTag("LeftHook"))
            {
                hapticsOHYeah.Vibrator(.03f, .4f, .3f, OVRInput.Controller.LTouch);
            }
        }
    }

    //public void Find_BoxCol() { 
    //meraColllider = GetComponent<BoxCollider>();
    //    Debug.Log("Oye box col ayyaa");
    //}


void Find_HapticsOhYeah()
{
    hapticsOHYeah = GameObject.Find("HapticsOHYeah").GetComponent<HapticsOHYeah>();
}
}
