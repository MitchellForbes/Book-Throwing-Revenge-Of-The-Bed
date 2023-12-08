using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPojectiles : MonoBehaviour
{
    private float timer;
    private float timeLimit = 4f;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeLimit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            Destroy(other.gameObject);




            Destroy(gameObject);
        }
    }

}
