using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 1f;
    [SerializeField]
    private float friction = .9f;
    private Rigidbody2D rb;
    private Vector2 tempVel;

    private RaycastHit2D[] hitBuffer = new RaycastHit2D[1];
    private Collider2D coll;
    public Collider2D other;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (!rb)
        {
            Debug.Log("Couldn't find a Rigidbody2D in " + gameObject.name);
        }

        if(rb.Cast(Vector2.right, hitBuffer, 0f) > 0)
        {
            print("Collision");
        }

        coll = GetComponent<Collider2D>();
        if (coll.bounds.Intersects(other.bounds))
        {
            print("Intersect");
        }
    }

    void FixedUpdate()
    {
        tempVel = rb.velocity; // In case something else changes the velocity
        if (Input.GetKey(KeyCode.UpArrow))
            tempVel.y += acceleration;
        if (Input.GetKey(KeyCode.DownArrow))
            tempVel.y -= acceleration;
        if (Input.GetKey(KeyCode.LeftArrow))
            tempVel.x -= acceleration;
        if (Input.GetKey(KeyCode.RightArrow))
            tempVel.x += acceleration;
        tempVel *= friction;
        rb.velocity = tempVel;
    }
}
