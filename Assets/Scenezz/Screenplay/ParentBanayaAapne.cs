using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBanayaAapne : MonoBehaviour
{
    GameObject leftHand;
    // Start is called before the first frame update
    void Start()
    {
        leftHand = GameObject.Find("LeftHandAnchor");
        gameObject.transform.SetParent(leftHand.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent == null) {
            gameObject.transform.SetParent(leftHand.transform);
        }
    }
}
