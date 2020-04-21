using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchScript : MonoBehaviour
{
    public Camera mainCamera;
    public Vector2 rotationSpeed;
    public bool reverse;
    private Vector2 lastMousePosition;
    private Vector2 newAngle = new Vector2(0, 0);
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        float view = cam.fieldOfView - scroll*10;

        cam.fieldOfView = Mathf.Clamp(value: view, min: 3.0f, max: 35f);
        if (Input.GetMouseButtonDown(0))
        {
            newAngle = mainCamera.transform.localEulerAngles;
            lastMousePosition = Input.mousePosition;

        }
        else if (Input.GetMouseButton(0))
        {
            if (!reverse)
            {
                newAngle.y -= (lastMousePosition.x - Input.mousePosition.x) * rotationSpeed.y*0.3f;
                newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotationSpeed.x*0.3f;
                mainCamera.transform.localEulerAngles = newAngle;
                lastMousePosition = Input.mousePosition;
            }
            else if (reverse)
            {
                newAngle.y -= (Input.mousePosition.x - lastMousePosition.x) * rotationSpeed.y*0.3f;
                newAngle.x -= (lastMousePosition.y - Input.mousePosition.y) * rotationSpeed.x*0.3f;
                mainCamera.transform.localEulerAngles = newAngle;
                lastMousePosition = Input.mousePosition;
            }
        }
    }
    public void DirectionChange()
    {
        if (!reverse)
        {
            reverse = true;
        }
        else
        {
            reverse = false;
        }
    }
}