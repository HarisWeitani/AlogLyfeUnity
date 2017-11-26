using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// money 10 digits
/// </summary>
public class TextManager : MonoBehaviour {

    public Text textName;
    public Text textHealth;
    public Text textStamina;
    public Text textMood;
    public Text textHunger;
    public Text textMoney;
    public Text textTime;

    

    public string inputName;

    // Use this for initialization
    void Start () {
        Debug.Log("TextManager Start");

    }

    // Update is called once per frame
    void Update () {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        if (Input.GetMouseButtonDown(0))
        {
            lifeScript.Money += 20;
            Debug.Log("On Mouse Down input");
        }
        textName.text = "Name : " + inputName;
        textHealth.text = "Health : " + lifeScript.Health;
        textStamina.text = "Stamina : " + lifeScript.Stamina;
        textMood.text = lifeScript.Mood + " : Mood";
        textHunger.text = lifeScript.Hunger + " : Hunger";
        textMoney.text = "Money : " + lifeScript.Money;
        textTime.text = lifeScript.time + ": 00";
    }

}
