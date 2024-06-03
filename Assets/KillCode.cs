using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCode : MonoBehaviour {
    // Update is called once per frame
    [SerializeField] private string tost = ("Batswinging");
    public void NewGameButtons()
    {
        Debug.Log(tost);
        Application.Quit();
    }
}
