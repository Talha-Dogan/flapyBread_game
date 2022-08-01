using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const int SceneBuildIndex = 0;
    public GameObject gameOverCanvas;
    private int score;



    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("game over");
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


}