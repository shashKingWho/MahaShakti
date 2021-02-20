using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticsOHYeah : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Vibrator(float duration, float frequency, float amplitude, OVRInput.Controller hillaController)
    {
        //this will be a StartCoroutine to start and stop the vibration
        StartCoroutine(HillaJilla(duration, frequency, amplitude, hillaController));
    }

    IEnumerator HillaJilla(float duration, float frequency, float amplitude, OVRInput.Controller hillaController)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, hillaController);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, hillaController);
    }
}
