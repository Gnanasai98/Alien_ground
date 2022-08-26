using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movements : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    [SerializeField] GameObject body;
    [SerializeField] float rotSpeed;
    [SerializeField] float hookRange;
    [SerializeField] LayerMask grapplinglayer;
    // Cache storage
    private Rigidbody2D rb;
    float inputX;
    PlayerAttributes rawData;
    private Camera mainCamera;
    private LineRenderer lineRenderer;
    private DistanceJoint2D joint;
    private PlayerAttributes rawInput;
    private Vector2 mouseStart, mouseEnd,shootingDir;
    Vector2 mousePos;
    bool grappling;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rawData = GetComponent<PlayerAttributes>();
        mainCamera = GetComponent<Camera>();
        lineRenderer = GetComponent<LineRenderer>();
        joint = GetComponent<DistanceJoint2D>();
        
        joint.enabled = false;

    }
    public void ApplyThrust(Vector2 direction, float speed)
    {
        rb.AddRelativeForce(direction * speed * Time.deltaTime);
        inputX = rawData.linearThrust * 10 * Time.fixedDeltaTime;
        if (inputX == 0)
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(rotSpeed * Time.deltaTime));
            return;
        }
        if (inputX < 0f)
        {
            Quaternion target = Quaternion.Euler(0, 0, rawData.goalRotational);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(rotSpeed * Time.deltaTime));
        }
        if (inputX > .1f)
        {
            Quaternion target = Quaternion.Euler(0, 0, -rawData.goalRotational);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(rotSpeed * Time.deltaTime));
        }
    }
    public void GrapplingAction()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            StartGrapple();
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            StopGrapple();
        }
    }

    private void StartGrapple()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, mousePos,10f, grapplinglayer);
        mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (hit.collider)
        {
            Debug.Log(hit.transform.gameObject.name);
            Debug.Log(mousePos);
        }

    }

    private void StopGrapple()
    {

    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
    }
}








//if (rawInput.shoot)
//{
//    Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
//    lineRenderer.SetPosition(0, mousePos);
//    lineRenderer.SetPosition(1, transform.position);

//    joint.connectedAnchor = mousePos;
//    joint.enabled = true;
//    lineRenderer.enabled = true;
//}
//else if (!rawInput.shoot)
//{
//    joint.enabled = false;
//    lineRenderer.enabled = false;
//}
//if (joint.enabled)
//{
//    lineRenderer.SetPosition(1, transform.position);
//}
//return;

//if (Mouse.current.leftButton.wasPressedThisFrame)
//{
//    mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

//    // RaycastHit2D detectInfo = Physics2D.Raycast(transform.position, mousePos,hookRange);
//    // Debug.Log(detectInfo.transform.gameObject.name);
//    RaycastHit2D detectInfo = Physics2D.Raycast(transform.position, mousePos, hookRange, grapplinglayer);

//    if (detectInfo)
//    {

//        lineRenderer.SetPosition(0, detectInfo.point);
//        lineRenderer.SetPosition(1, transform.position);
//        joint.connectedAnchor = detectInfo.point;
//        joint.enabled = true;
//        lineRenderer.enabled = true;
//    }

//    return;
//}
//else if (Mouse.current.leftButton.wasReleasedThisFrame)
//{
//    joint.enabled = false;
//    lineRenderer.enabled = false;
//}
//if (joint.enabled)
//{
//    lineRenderer.SetPosition(1, transform.position);
//}



//worldPos = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
//mouseStart = worldPos;

//worldPos = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
//mouseEnd = worldPos;
//shootingDir = mouseStart - mouseEnd;





//if (direction.x < Vector2.zero.x || direction.x > Vector2.zero.x)
//    target = target == 0 ? 1 : 0;

//current = Mathf.MoveTowards(current, target, .5f * Time.deltaTime);

//Debug.Log(current);
//if (direction == Vector2.left && direction == Vector2.right) return;
//if (direction != Vector2.left && direction != Vector2.right) return;


//if (direction == Vector2.left)
//{
//    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(goalRotational), curve.Evaluate(current));//(mathf.pingpong(current, 0.5f)));

//}

//if (direction == Vector2.right)
//{
//    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(-goalRotational), curve.Evaluate(current));//(mathf.pingpong(current, 0.5f)));
//}


















//if (direction < Vector2.zero)
//    target = target == 0 ? 1 : 0;

//current = Mathf.MoveTowards(current, target, .5f * Time.deltaTime);
//if (direction == Vector2.left && direction == Vector2.right) return;

//if (direction == Vector2.left)
//{
//    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(goalRotational), curve.Evaluate(current));//(Mathf.PingPong(current, 0.5f)));
//}
////else
////{
////    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(goalRotational), Quaternion.Euler(Vector3.zero), curve.Evaluate(current));//(Mathf.PingPong(current, 0.5f)));
////}
//if (direction == Vector2.right)
//{
//    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(-goalRotational), curve.Evaluate(current));//(Mathf.PingPong(current, 0.5f)));
//}
////else
////{
////    body.transform.rotation = Quaternion.Lerp(Quaternion.Euler(goalRotational), Quaternion.Euler(Vector3.zero), curve.Evaluate(current));//(Mathf.PingPong(current, 0.5f)));
////}