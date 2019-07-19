using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Button newGameButton;
    public Button NoAdsButton;
    public Button exitGameButton;
    
    public string newGameSceneName;
    
    public void Awake() {
        newGameButton.onClick.AddListener(newGame);
        exitGameButton.onClick.AddListener(exitGame);
    }
    public void newGame() {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void NoAds() {

    }

    public void exitGame() {
        Application.Quit();
    }

}
