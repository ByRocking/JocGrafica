using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlGreenLight : MonoBehaviour
{
    public Slider slider;
    public Light light;

    public KeyCode increaseLight = KeyCode.X;
    public KeyCode decreaseLight = KeyCode.Z;

    void FixedUpdate()
    {
        MyInput();
    }

    private void MyInput()
    {
        if (Input.GetKey(increaseLight))
        {
            slider.value += 1;
            light.intensity = slider.value / 10;
        }
        if (Input.GetKey(decreaseLight))
        {
            slider.value -= 1;
            light.intensity = slider.value / 10;
        }
    }
}
