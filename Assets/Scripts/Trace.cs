using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour
{

    public Vector3 startPoint;
    public Vector3 endPoint;

    public GameObject target;
    public GameObject spawnedTarget;

    public bool timeractive;

    private bool spawned;

    private Vector3 position;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeractive && !spawned)
        {
            spawnedTarget = Instantiate(target, startPoint, Quaternion.Euler(new Vector3(90, 180, 0)));
            spawned = true;
        }

        while (timeractive && spawned)
        {
            spawnedTarget.transform.position = Vector3.MoveTowards(transform.position, endPoint, 5);
        }

    }
}
