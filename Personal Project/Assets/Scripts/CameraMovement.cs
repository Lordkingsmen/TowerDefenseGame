using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 60.0f;
    private float horizontalInput;
    private float forwardInput;
    private float turnInput;
    private float zoomTotal = 5.0f;
    private float zoom;
    private float zoomSens = 1.0f;
    private float moveSens = 1.0f;
    public Camera cameraZoom;
    public Slider scrollSensSlider;
    public Slider moveSensSlider;

    void Start()
    {

    }

    public void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Turn");
        zoom = Input.GetAxis("Mouse ScrollWheel");
        cameraZoom.orthographicSize = zoomTotal;
        transform.Translate((Vector3.forward * Time.deltaTime * speed * forwardInput) * moveSens);
        transform.Translate((Vector3.right * Time.deltaTime * speed * horizontalInput) * moveSens);
        transform.Rotate(Vector3.up, (Time.deltaTime * turnSpeed * turnInput) * moveSens);
        zoomTotal = zoomTotal - zoom * zoomSens;
        zoomSens = scrollSensSlider.value;
        moveSens = moveSensSlider.value;
    }
}
