using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public bool used;
    public int index;
    public Collector collector;
    public GameObject sfx;
    public GameObject vfx;

    void Update()
    {
        if(used)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, (-index*0.3f), 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Barrier"))
        {
            sfx.gameObject.GetComponent<Sfx>().Barrier();
            vfx.SetActive(true);
            StartCoroutine(resetAnimation());
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(loseBarrel());
        }
    }

    private IEnumerator loseBarrel()
    {
        yield return new WaitForSeconds(0.3f);
        collector.barrels -= 1;
        transform.parent = null;
    }

    private IEnumerator resetAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        vfx.SetActive(false);
    }
}
