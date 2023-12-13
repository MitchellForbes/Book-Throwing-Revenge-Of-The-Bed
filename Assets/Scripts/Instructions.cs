using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{
    private bool inRange;


    public TextMeshProUGUI instructionsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
            instructionsText.gameObject.SetActive(false);
        }
    }

    private void OnMouseOver()
    {
        if (inRange) 
        {
            instructionsText.gameObject.SetActive(true);
        }
            
    }

    private void OnMouseExit()
    {
        instructionsText.gameObject.SetActive(false);
    }

}
