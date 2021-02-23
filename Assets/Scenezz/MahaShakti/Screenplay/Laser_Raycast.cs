using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Raycast : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot() {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, range);
    }
}
