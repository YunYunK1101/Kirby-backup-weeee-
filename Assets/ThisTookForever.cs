using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisTookForever : MonoBehaviour {

    Rigidbody2D rb;
    Vector3 help;
    float x = 6.91f;
    float y = 11.55f;
    float z = -2;
    public float a;
    public float b;
    public bool woo;
    Animator mAnimator;

    // Use this for initialization
    void Start()
    {

        mAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        help = new Vector3(x, y, z);
        rb.position = help;
    }

    // Update is called once per frame
    void FixedUpdate()
    {//fixedUpdate is better for physics for some reason?
     //we = false;
        a = rb.position.x;
        b = rb.position.y;

        if (a >= -3.08 && b >= 1.55)
        {
            help = new Vector3(a - 0.05f, b - 0.05f, -2);
            rb.MovePosition(help);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        mAnimator.SetTrigger("Crash");
        Debug.Log("Hello");
        Destroy(gameObject, 1.5f);
    }
}
