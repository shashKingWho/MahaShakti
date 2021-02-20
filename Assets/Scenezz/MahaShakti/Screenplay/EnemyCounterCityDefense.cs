using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class EnemyCounterCityDefense : MonoBehaviour
{
    public GameManager gameManager;


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
        if (other.gameObject.CompareTag("enemy")) {
            //Debug.Log("enemy Increased");
            //increase the slider value
            gameManager.asurArmyMeter.value++;
            //update the count of GameManager
            
        }
    }

    void Find_GameManager() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
