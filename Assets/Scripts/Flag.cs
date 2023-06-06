using HmsPlugin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public GameObject sfx;
    public GameObject gameOverEffect;
    public GameObject environment;
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrier"))
        {
            gameOverEffect.SetActive(true);
            sfx.gameObject.GetComponent<Sfx>().GameOver();
            StartCoroutine(waitForGameOver());
            
        }
    }

    IEnumerator waitForGameOver()
    {
        environment.SetActive(false);
        yield return new WaitForSeconds(1);
        HMSAdsKitManager.Instance.ShowInterstitialAd();
        PlayerPrefs.SetInt("level", index);
        SceneManager.LoadScene("GameOverScene");
    }

}
