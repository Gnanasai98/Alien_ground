using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //
    [Header("Arguments")]
    [SerializeField] float speed;

    // receiving the raw input data from the manual input

    //cache
    Movements mover;
    PlayerAttributes inputs;
    // process 
    private void Start()
    {
        mover = GetComponent<Movements>();
        inputs = GetComponent<PlayerAttributes>();
    }
    private void Update()
    {
        Movements();
        mover.GrapplingAction();
    }

    private void Movements()
    {
        if (inputs.upwardThrust)
        {
            mover.ApplyThrust(Vector2.up,this.speed);
        }
     
        if (inputs.linearThrust < 0f)
        {
            mover.ApplyThrust(Vector2.left,this.speed);
        }
    
        if (inputs.linearThrust > 0f)
        {
            mover.ApplyThrust(Vector2.right,this.speed);
        }
    }















































    //private void Stabilizer()
    //{
    //    if (!upwardThrust || !leftThrust ||!rightThrust)
    //    {
    //        mover.InterpolationBetweenAngle(transform.eulerAngles, Vector2.zero);
    //        return;
    //    }
    //    if(upwardThrust && !leftThrust||upwardThrust && !rightThrust)
    //    {
    //        mover.InterpolationBetweenAngle(transform.eulerAngles, Vector2.zero);
    //    }
    //    if (upwardThrust && leftThrust || leftThrust)
    //    {
    //        mover.InterpolationBetweenAngle(Vector2.zero, goalRotational);
    //    }
    //    if (upwardThrust && rightThrust || rightThrust)
    //    {
    //        mover.InterpolationBetweenAngle(Vector2.zero, -goalRotational);
    //    }
    //    else
    //    {
    //        return;
    //    }
    //}
}
