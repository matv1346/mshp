using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    float InHor;
    float InVert;
    public int speed = 6;

    void invers()
    {
        InHor = Input.GetAxis("Horizontal");
        InVert = Input.GetAxis("Vertical");

        if (InHor != 0)
            rb.velocity = new Vector2(speed * InHor, rb.velocity.y);

        if (InHor > 0)
            gameObject.transform.localScale = new Vector3(3, 3, 3);

        if (InHor < 0)
            gameObject.transform.localScale = new Vector3(-3, 3, 3);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        invers();

        if (Input.GetButtonDown("Horizontal"))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * 11, ForceMode2D.Impulse);
        }
    }
}

