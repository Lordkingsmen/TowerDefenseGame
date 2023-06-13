using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
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
    public Button startButton;
    public GameObject pauseScreen;
    public GameObject homeScreen;
    private bool paused;

    void Start()
    {

    }

    void Update()
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
