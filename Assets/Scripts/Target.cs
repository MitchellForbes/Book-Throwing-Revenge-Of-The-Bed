using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    Score score;

    public void OnDestroy()
    {
        SpawnTarget targetcount = GameObject.Find("TargetSpawner").GetComponent<SpawnTarget>();
        targetcount.counter -= 1;
        Debug.Log("Target Destroyed");
        score = GameObject.Find("UI").GetComponent<Score>();
        score.AddPoints();
    }
}
