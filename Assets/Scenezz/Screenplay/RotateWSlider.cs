using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.UI; // with this use SliderEventData
using UnityEngine.UI;

public class RotateWSlider : MonoBehaviour
{
    float cubeSpeed;
    // Start is called before the first frame update

    public Slider hiddenSlider;
    public float mrSldValue;

    public Transform fullSlider;

    void Start()
    {
        //hiddenSlider = GameObject.FindWithTag("SliderHidden");
        hiddenSlider = GameObject.FindWithTag("SliderHidden").GetComponent<Slider>();
        cubeSpeed = 0f;

        fullSlider = GameObject.FindWithTag("Don").GetComponent<Transform>();
        //hiddenSlider.maxValue = 100;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, cubeSpeed * Time.deltaTime, 0);
    }

    // when the speed increases the object rotates faster

    public void SpeedBadhaNa(SliderEventData sliderValue)
    {
        float hmm = sliderValue.NewValue;
        mrSldValue = hmm * 100; // multiplying to get through 2 decimals
        fullSlider.localScale = new Vector3(0f, hmm, 0f);


        cubeSpeed = mrSldValue;
        Debug.Log("Hey " + sliderValue); // Doesn't work
        Debug.Log("YO Yo" + sliderValue.NewValue);  // this NewValue gives value in float


    }

    public void UpdateThyValue()
    {
        //hiddenSlider.value = sliderValue.NewValue;
    }
}
