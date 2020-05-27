using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 moveVector;

    private new Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveVector = new Vector2(x, y);

        if(moveVector.magnitude > 1.0f)
        {
            moveVector.Normalize();
        }
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = moveVector * speed;
    }
}
