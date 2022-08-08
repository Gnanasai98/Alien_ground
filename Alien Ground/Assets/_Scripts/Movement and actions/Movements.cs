using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;

    [SerializeField] GameObject body;
    // Cache storage
    private Rigidbody2D rb;
    float current, target;
    float inputX;
    PlayerAttributes inputs;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputs = GetComponent<PlayerAttributes>();

    }

    public void ApplyThrust(Vector2 direction, float speed)
    {
        rb.AddRelativeForce(direction * speed * Time.deltaTime);
        inputX = inputs.linearThrust * 10 * Time.fixedDeltaTime;
        Debug.Log(inputX);
        if(inputX == 0)
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(.05f));
            return;
        }
        if (inputX < 0f)
        {
            Quaternion target = Quaternion.Euler(0, 0, inputs.goalRotational);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(.05f));
        }
        if (inputX > .1f)
        {
            Quaternion target = Quaternion.Euler(0, 0, -inputs.goalRotational);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, curve.Evaluate(.05f));
        }
    }
    
}





















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