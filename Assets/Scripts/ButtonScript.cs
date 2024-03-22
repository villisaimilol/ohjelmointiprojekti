using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonScript : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private Button button;
    public bool isGameActive;
    public GameObject titleScreen;
    // Start is called before the first frame update
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        isGameActive = true;
        button = GetComponent<Button>();
        titleScreen.gameObject.SetActive(false);

    }

    public void GameOpen()
    {
        SceneManager.LoadScene("Prototype 3");
    }
}
