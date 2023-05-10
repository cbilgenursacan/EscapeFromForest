using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public GameObject sfx;
    public GameObject gameOverEffect;
    public GameObject finishEffect;
    public GameObject mainBarrel;
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
        mainBarrel.GetComponent<Movement>().enabled = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOverScene");
    }

}
