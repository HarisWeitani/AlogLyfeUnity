using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    public void playDirt()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Stamina -= 5;
        lifeScript.Mood += 10;
        lifeScript.Hunger -= 5;

        lifeScript.time += 1;

        Debug.Log("Play Dirt");
    }

    public void playWithFriends()
    {
        Debug.Log("Dont want play with friends");
    }

    public void playComputer()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Stamina -= 5;
        lifeScript.Mood += 20;
        lifeScript.Hunger -= 5;
        lifeScript.Money -= 5;

        lifeScript.time += 1;

        Debug.Log("Play Computer");
    }

    public void playBeatTheMeat()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Stamina -= 10;
        lifeScript.Mood += 40;
        lifeScript.Hunger -= 5;
        lifeScript.Money -= 5;

        lifeScript.time += 1;

        Debug.Log("Play Beat The Meat");
    }
}
