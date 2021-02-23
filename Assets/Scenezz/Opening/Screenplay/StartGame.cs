using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
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
        Debug.Log("BhidAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        if (other.gameObject.CompareTag("RightHook") || other.gameObject.CompareTag("LeftHook")) {
            SceneManager.LoadScene("MarutiMR_King");
        }
    }
}
