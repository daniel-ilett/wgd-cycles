using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObject : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void AddForce(Vector2 force)
    {
        rigidbody.velocity = force;
    }
}
