using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Cache storage
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ApplyThrust(Vector2 direction, float speed)
    {
        rb.AddRelativeForce(direction * speed * Time.deltaTime);
    }
}
