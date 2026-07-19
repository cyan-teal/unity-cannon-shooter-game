using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Firer : MonoBehaviour
{
    public Button fireButton;
    public AudioSource fireNoise;
    public Toggle pauseButton;
    public GameObject SpawnPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        Button Firebtn = fireButton.GetComponent<Button>();
        Firebtn.onClick.AddListener(TaskOnClickFire); 
    }

    public void TaskOnClickFire()
    {
        bool gameIsUnpaused = !pauseButton.isOn;
        if (gameIsUnpaused)
        {
            Instantiate(SpawnPrefab, this.transform.position, this.transform.rotation);
            fireNoise.Play();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
