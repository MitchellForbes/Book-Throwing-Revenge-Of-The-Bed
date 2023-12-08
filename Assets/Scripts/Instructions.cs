using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{



    public TextMeshProUGUI instructionsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        instructionsText.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        instructionsText.gameObject.SetActive(false);
    }

}
