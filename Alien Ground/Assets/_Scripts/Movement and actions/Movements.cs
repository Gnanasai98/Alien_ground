using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    [SerializeField] GameObject body;
    [SerializeField] private Vector3 goalRotational;
    [SerializeField]
    // Cache storage
    private Rigidbody2D rb;




    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ApplyThrust(Vector2 direction, float speed)
    {
        rb.AddRelativeForce(direction * speed * Time.deltaTime);
        body.transform.rotation = Quaternion.Euler(0, 0, 0);
        
        if(direction.x != 0)
        {
            if (direction.x < 0f)
            {
                body.transform.rotation = Quaternion.Euler(0, 0, 10f);
            }
            if (direction.x > .1f)
            {
                body.transform.rotation = Quaternion.Euler(0, 0, -10f);
            }
        }
    }
}







































//if (direction == Vector2.left)
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