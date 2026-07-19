using UnityEngine;
using UnityEngine.UI;

public class VictoryDefeatManager : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;
    public PlayerData playerData;
    public Toggle pauseButton;
    public int killRequirement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        victoryScreen.SetActive(false);
        defeatScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerData.Kills >= killRequirement)
        {
            endGame(victoryScreen);
        } 
        else if(playerData.health <= 0)
        {
            endGame(defeatScreen);
        }
    }

    void endGame(GameObject screen)
    {
        pauseButton.isOn = true;
        screen.SetActive(true);
    }
}
