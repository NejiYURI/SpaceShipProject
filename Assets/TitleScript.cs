using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
