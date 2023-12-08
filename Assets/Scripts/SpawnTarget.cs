using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{

    public int counter;
    public GameObject bedTarget;

    private GameObject[] Beds;

    public bool timerActive = false;
    // Start is called efore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            if (counter < 3)
            {
                var position = new Vector3(Random.Range(-40, 40), Random.Range(10, 20), Random.Range(28, 48));
                Instantiate(bedTarget, position, Quaternion.Euler(new Vector3(90, 180, 0)));
                counter += 1;
            }
        }
    }
    
    public void DestroyAllSpawned()
    {
        Beds = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject targets in Beds)
        {
            Destroy(targets);
        }
    }

}
