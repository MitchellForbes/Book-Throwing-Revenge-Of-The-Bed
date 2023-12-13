using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraMove : MonoBehaviour
{

    public Transform player;

    public float mouseSensitivity = 100f;
    float cameraVerticalRotation = 0f;

    public TextMeshProUGUI sensNumber;

    private void Start()
    {
        mouseSensitivity = 100f * 10;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        sensNumber.text = mouseSensitivity.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);



    }

    public void SensitivitySlider(float sens)
    {
        sens = Mathf.Round(sens * 100) / 100;
        mouseSensitivity = sens * 10;
        sensNumber.text = sens.ToString();
    }
}
