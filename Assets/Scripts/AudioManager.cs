//using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Toggle Soundtoggle;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Soundtoggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Soundtoggle.isOn)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }

        
    }
}
