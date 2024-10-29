using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiScene : MonoBehaviour
{
    public void playmenu()
    {
        SceneManager.LoadScene("playmenu");
    }

    public void QuizFIX()
    {
        SceneManager.LoadScene("QuizFIX");
    }

    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Video()
    {
        SceneManager.LoadScene("Video");
    }

    public void Video2()
    {
        SceneManager.LoadScene("Video2");
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}