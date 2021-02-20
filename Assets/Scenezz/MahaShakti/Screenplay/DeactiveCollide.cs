using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveCollide : MonoBehaviour
{
    public GameObject pooraAsur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Don"))
        {
            //deactive
            pooraAsur.SetActive(false);
        }
    }
}
