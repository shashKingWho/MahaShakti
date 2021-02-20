using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTransform : MonoBehaviour
{
    public Transform peechaKaro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (peechaKaro == null) {
            FollowKaro();
        }
    }

    void FollowKaro() {
        peechaKaro = GameObject.Find("Khopra").GetComponent<Transform>();
    }
}
