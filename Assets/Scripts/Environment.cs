using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject environment1;
    public GameObject environment2;
    public GameObject environment3;
    private List<GameObject> environments;
    public GameObject player;
    private float distance;
    private int generateCount;
    private float baseEnvSize;

    private void Start()
    {
        baseEnvSize = environment1.GetComponent<Collider>().bounds.size.z;
        distance = environment1.transform.position.z + (baseEnvSize / 2);
        generateCount = 0;
    }
    private void Update()
    {
        player.transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        if(player.transform.position.z >= distance)
        {
            int RandomInt = Random.Range(0, 3);
            generateCount += 1;

            if(RandomInt == 0)
            {
                Debug.Log("1");
                GameObject TempEnv = Instantiate(environment1, transform);
                TempEnv.transform.position = new Vector3(environment1.transform.position.x , environment1.transform.position.y, (environment1.transform.position.z + (2+ generateCount) * baseEnvSize));
                
            }
            else if (RandomInt == 1)
            {
                Debug.Log("2");
                GameObject TempEnv = Instantiate(environment2, transform);
                TempEnv.transform.position = new Vector3(environment1.transform.position.x, environment1.transform.position.y, (environment1.transform.position.z + (2 + generateCount) * baseEnvSize));
                
            }
            else if (RandomInt == 2)
            {
                Debug.Log("3");
                GameObject TempEnv = Instantiate(environment3, transform);
                TempEnv.transform.position = new Vector3(environment1.transform.position.x, environment1.transform.position.y, (environment1.transform.position.z + (2 + generateCount) * baseEnvSize));
             
            }
            distance += (baseEnvSize / 2); 
        }
    }
}
