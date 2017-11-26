using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public Button buttonStatus;
    public bool status = false;

	void Update () {
        if(status == true)
        {
            buttonStatus.interactable = false;
        }else
        {
            buttonStatus.interactable = true;
        }
	}
}
