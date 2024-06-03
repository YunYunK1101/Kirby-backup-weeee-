using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class metoerHit : MonoBehaviour {
    Animator mAnimator;
    Vector3 p;
    float startX;
    float startY;
    [SerializeField] MeteorDown meteorDown;
    Rigidbody2D rig;
    bool woo;
    [SerializeField] private string tast = ("meteor go boom");

    // Use this for initialization
    void Awake() {//apparently its better than start when using other varbiables?

        
        rig = GetComponent<Rigidbody2D>();
        mAnimator = GetComponent<Animator>();
        p = new Vector3(-9, 14, -2);
        rig.position = p;
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        if (meteorDown.woo)
        {
            startX = meteorDown.a;
            startY = meteorDown.b;
          //  Debug.Log(meteorDown.a);
            p = new Vector3(startX, startY, -2);
            rig.position = p;
            woo = true;
        }

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("wo");
        if (woo) { 
            mAnimator.SetTrigger("Being Hit");
            Destroy(gameObject,0.75f);
            StartCoroutine(timerCourntine(1));
        }
    }

    private IEnumerator timerCourntine(int v)
    {
        Debug.Log("he");
        yield return new WaitForSecondsRealtime(0.5f);
        Debug.Log("ho");
        SceneManager.LoadScene(tast);
    }
}
