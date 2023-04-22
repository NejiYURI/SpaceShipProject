using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    public Image JoystickImg;

    private void Start()
    {
        if (GameSettingScript.instance != null)
        {
            JoystickImg.color = GameSettingScript.instance.IsJoycon ? Color.white : Color.black;
        }
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void ChangeJoycon()
    {
        if (GameSettingScript.instance != null)
        {
            GameSettingScript.instance.IsJoycon = !GameSettingScript.instance.IsJoycon;
            JoystickImg.color = GameSettingScript.instance.IsJoycon ? Color.white : Color.black;
        }
    }
}
