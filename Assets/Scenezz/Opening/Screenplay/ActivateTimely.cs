using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTimely : MonoBehaviour
{
    public GameObject gayabNahi;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(prakatHua());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator prakatHua() {
        
        yield return new WaitForSeconds(2f);
        gayabNahi.SetActive(true);
    }
}
