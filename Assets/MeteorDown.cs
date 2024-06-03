using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorDown : MonoBehaviour {
    Rigidbody2D rb;
    Vector3 help;
    float x = 6.91f;
    float y = 11.55f;
    float z = -2;
    public float a;
    public float b; 
    public bool woo; 

    Boolean we = false;
    // Use this for initialization
    void Start () {

       // woo = false;
        rb = GetComponent<Rigidbody2D>();
        help = new Vector3(x, y, z);
        rb.position = help;
    }

	// Update is called once per frame
	void FixedUpdate () {//fixedUpdate is better for physics for some reason?
        //we = false;
       a = rb.position.x;
       b = rb.position.y;

        help  = new Vector3(a - 0.05f, b - 0.05f, -2);
        rb.MovePosition(help);
        if (Input.GetKeyDown(KeyCode.A))
        {
            we = true;
        }


        if (we == false && a <= -8.97f && b <= -2.86)
        {
            Debug.Log("this works");
            Destroy(gameObject);
            SceneManager.LoadScene("LoseScreen");
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (we)
        {
            Debug.Log("meteor collides");// checking for collision
            woo = true;
            Debug.Log(woo);
            Destroy(gameObject);
           
        }
    }
}
