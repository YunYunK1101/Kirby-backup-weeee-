using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAAAAAAAA : MonoBehaviour
{

    private Animator mAnimator;
    // Use this for initialization
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
                mAnimator.SetTrigger("A button");

        }
    }
}
