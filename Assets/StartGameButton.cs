using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour {

    [SerializeField] private string tost = ("Batswinging");
    public void NewGameButtons()
    {
        SceneManager.LoadScene(tost);
    }
}
