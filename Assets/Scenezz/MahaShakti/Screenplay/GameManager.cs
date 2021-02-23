using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string sceneName;
    public Slider asurArmyMeter;

    // Start is called before the first frame update
    void Start()
    {
        //sceneName = SceneManager.GetActiveScene().name;
        sceneName = "Opening";

        asurArmyMeter.maxValue = 5;
        asurArmyMeter.minValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (asurArmyMeter.value >= 5)
        {
            NowRestart(sceneName);
        }
    }



    ///SceneManagment below

    public void NowRestart(string activeSceneHere) {
        // the scene sends: scene = SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(activeSceneHere);
        SceneManager.LoadScene(activeSceneHere);
    }
}
