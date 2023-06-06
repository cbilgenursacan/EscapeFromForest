using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Store;
    public GameObject Settings;

    // Start is called before the first frame update
    public void restart()
    {
        int index = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene(index);
    }

    // Update is called once per frame
    public void exit()
    {
        Application.Quit();
    }

    public void openHomeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void startDayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void startNightScene()
    {
        SceneManager.LoadScene(2);
    }

    public void openStore()
    {
        Store.SetActive(true);
    }

    public void closeStore()
    {
        Store.SetActive(false);
    }

    public void openSettings()
    {
        Settings.SetActive(true);
    }

    public void closeSettings()
    {
        Settings.SetActive(false);
    }

}
