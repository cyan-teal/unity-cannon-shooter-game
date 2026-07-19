//using Mono.Cecil.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
//using static UnityEditor.SceneView;

public class Aimer : MonoBehaviour
{
    public Slider slider01;
    public GameObject gun;
    public Toggle pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        // Set slider min/max values, not whole numbers and initial values
        slider01.minValue = -30;
        slider01.maxValue = 30;
        slider01.wholeNumbers = false;
        slider01.value = 0;
        
    }
        
    public void SliderChanged()

    {
        bool gameIsUnpaused = !pauseButton.isOn;
        if (gameIsUnpaused)
        {
            Debug.Log("Slider was moved");
            Debug.Log(slider01.value);

            gun.transform.rotation = Quaternion.Euler(90f, slider01.value, 0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
                   
    } 
}
