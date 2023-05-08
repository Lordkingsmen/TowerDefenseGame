using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Privarte Variables
    private float speed = 15.0f;
    private float turnSpeed = 60.0f;
    private float horizontalInput;
    private float forwardInput;
    private float turnInput;
    private float zoomTotal = 5.0f;
    private float zoom;
    private GameManager gameManager;
    public Camera cameraZoom;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<gameManager>().zoomSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera's Controls
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Turn");
        zoom = Input.GetAxis("Mouse ScrollWheel");
        cameraZoom.orthographicSize = zoomTotal;
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * turnInput);
        zoomTotal = zoomTotal - zoom * zoomSpeed;
    }
}
