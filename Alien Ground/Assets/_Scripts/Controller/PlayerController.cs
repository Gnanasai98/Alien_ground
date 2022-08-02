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

    // Cache storage
    Rigidbody2D rb;
    // process 
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movements();
    }

    private void Movements()
    {
        if (upwardThrust)
        {
            ApplyThrust(Vector2.up);
        }
     
        if (leftThrust)
        {
            ApplyThrust(Vector2.left);
        }
    
        if (rightThrust)
        {
            ApplyThrust(Vector2.right);
        }
    
    }

    private void ApplyThrust(Vector2 direction)
    {
        rb.AddRelativeForce(direction * speed * Time.deltaTime);
    }
}
