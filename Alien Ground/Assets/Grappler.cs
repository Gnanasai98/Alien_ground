using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    private Camera mainCamera;
    private LineRenderer lineRenderer;
    private DistanceJoint2D joint;
    private void Start()
    {
        mainCamera = GetComponent<Camera>();
        lineRenderer = GetComponent<LineRenderer>();
        joint = GetComponent<DistanceJoint2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, mousePos);
            joint.connectedAnchor = mousePos;
            joint.enabled = true;
            lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            joint.enabled = false;
            lineRenderer.enabled = false;
        }
        if (joint.enabled)
        {
           // lineRenderer.SetPosition(1, transform.position);
        }
    }
}
