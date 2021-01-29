using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 0;

    [SerializeField]
    bool canMove;

    public bool CanMove { get { return canMove; } set { canMove = value; } }

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        var pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
