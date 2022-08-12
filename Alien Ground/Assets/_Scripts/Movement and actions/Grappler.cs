using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    //private Camera mainCamera;
    //private LineRenderer lineRenderer;
    //private DistanceJoint2D joint;
    //private PlayerAttributes rawInput;
    //private void Start()
    //{
    //    mainCamera = GetComponent<Camera>();
    //    lineRenderer = GetComponent<LineRenderer>();
    //    joint = GetComponent<DistanceJoint2D>();
    //    rawInput = GetComponent<PlayerAttributes>();
    //}
    //private void Update()
    //{
    //    GrapplingAction();

    //}

    //private void GrapplingAction()
    //{
    //    if (rawInput)
    //    {
    //        Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
    //        lineRenderer.SetPosition(0, mousePos);
    //        lineRenderer.SetPosition(1, transform.position);

    //        joint.connectedAnchor = mousePos;
    //        joint.enabled = true;
    //        lineRenderer.enabled = true;
    //    }
    //    else if (!rawInput)
    //    {
    //        joint.enabled = false;
    //        lineRenderer.enabled = false;
    //    }
    //    if (joint.enabled)
    //    {
    //        lineRenderer.SetPosition(1, transform.position);
    //    }
    //}
}
