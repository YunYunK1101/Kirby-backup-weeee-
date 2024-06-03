using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackButton : MonoBehaviour {

    [SerializeField] private string tist = ("Start");
    public void NewGameButtons()
    {
        SceneManager.LoadScene(tist);
    }

}
