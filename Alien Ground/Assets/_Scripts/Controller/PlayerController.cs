using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //
    [Header("Atributes")]
    [SerializeField] float speed;
    // receiving the raw input data from the manual input
    public bool leftThrust;
    public bool rightThrust;
    public bool upwardThrust;
    //cache
    Movements mover;
    // process 
    private void Start()
    {
        mover = GetComponent<Movements>();
    }
    private void Update()
    {
        Movements();
    }

    private void Movements()
    {
        if (upwardThrust)
        {
            mover.ApplyThrust(Vector2.up,this.speed);
        }
     
        if (leftThrust)
        {
            mover.ApplyThrust(Vector2.left,this.speed);
        }
    
        if (rightThrust)
        {
            mover.ApplyThrust(Vector2.right,this.speed);
        }
       
    }

   
}
