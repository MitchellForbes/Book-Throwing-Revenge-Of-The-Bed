using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Menu : MonoBehaviour
{

    private bool isSettingsOpen;
    public GameObject settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isSettingsOpen)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }


    public void Pause()
    {
        Time.timeScale = 0.0f;
        settings.SetActive(true);
        isSettingsOpen = true;
        this.GetComponent<CameraMove>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Resume()
    {
        settings.SetActive(false);
        Time.timeScale = 1.0f;
        isSettingsOpen = false;
        this.GetComponent<CameraMove>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
