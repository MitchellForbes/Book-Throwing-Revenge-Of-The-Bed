using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    public float speed = 20f;
    public Rigidbody rb;
    public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        verticalInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
       
        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput; // new Vector3(horizontalInput, 0, verticalInput);
        cc.Move(movement);
        //transform.Translate(movement * speed * Time.deltaTime);

    }

 
}
