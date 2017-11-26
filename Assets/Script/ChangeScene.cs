using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public int sceneNumber;

    public void ChangeToScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Debug.Log("Change Scene to " + sceneNumber);
    }

    //for testing purpose
    public void showButton()
    {
        Debug.Log("Testing Purpose");
    }
}
