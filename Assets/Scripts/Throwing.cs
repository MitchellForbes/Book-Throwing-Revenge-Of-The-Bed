using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody projectile;
    public Transform spawnPoint;



    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, spawnPoint.position, projectile.rotation);

            clone.velocity = spawnPoint.TransformDirection(Vector3.forward * 40);
        }
    }
}
