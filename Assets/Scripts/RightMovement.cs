using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    //kent worked on this
    // Start is called before the first frame update
    //right movement of cars

    public Rigidbody2D rb;
    public float speed = .5f;
    // Update is called once per frame
    public void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + Vector2.right * Time.fixedDeltaTime *speed);
    }
}
