
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonU : MonoBehaviour
{
    [SerializeField] private string test = ("HowtoPlay");
    public void NewGameButtons()
    {
        SceneManager.LoadScene(test);
    }

}


