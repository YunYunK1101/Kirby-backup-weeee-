using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bat collides");
        Destroy(collision.gameObject);
        
    }
}

