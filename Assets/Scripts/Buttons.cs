using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart()
    {
        SceneManager.LoadScene("StartScene");
    }

    // Update is called once per frame
    public void exit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void startDayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void startNightScene()
    {
        SceneManager.LoadScene(2);
    }

}
