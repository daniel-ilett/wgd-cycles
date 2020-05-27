using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private SwingObject swingObject;

    private Vector2 moveVector;
    private bool isSwinging = false;

    private new Rigidbody2D rigidbody;

    public static PlayerController instance = null;

    private void Awake()
    {
        instance = this;
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

        isSwinging = Input.GetButton("Fire1");
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = moveVector * speed;

        var offset = swingObject.transform.position - transform.position;
        var rotation = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, rotation);

        if(isSwinging)
        {
            swingObject.AddForce(transform.up * 5.0f);
        }
    }
}
