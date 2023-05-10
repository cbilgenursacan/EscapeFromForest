using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public GameObject mainBarrel;
    public int barrels;
    public int coinCollected = 0;
    public GameObject sfx;
    public GameObject coins;
    public GameObject vfx;

    private void Update()
    {
        mainBarrel.transform.position = new Vector3(transform.position.x, 0.125f + (barrels*0.3f), transform.position.z);
        transform.localPosition = new Vector3(0, (-barrels * 0.3f), 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel") && !other.gameObject.GetComponent<Barrel>().used)
        {
            sfx.gameObject.GetComponent<Sfx>().Barrel();
            barrels += 1;
            other.gameObject.GetComponent<Barrel>().used = true;
            other.gameObject.GetComponent<Barrel>().index = barrels;
            other.transform.parent = mainBarrel.transform;
        }

        if (other.CompareTag("Coin"))
        {
            vfx.SetActive(true);
            StartCoroutine(resetAnimation());
            sfx.gameObject.GetComponent<Sfx>().Coin();
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            coinCollected += 1;
            coins.gameObject.GetComponent<Text>().text = "COINS:" + coinCollected;
        }
    }
    IEnumerator resetAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        vfx.SetActive(false);
    }
}
