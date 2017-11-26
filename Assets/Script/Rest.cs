using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : MonoBehaviour {

    public void restStreet()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 10;
        lifeScript.Stamina += 10;
        lifeScript.Mood += 10;

        lifeScript.time += 1;

        Debug.Log("Rest Street");
    }

    public void restShelter()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 20;
        lifeScript.Stamina += 20;
        lifeScript.Mood += 20;
        lifeScript.Money -= 20;

        lifeScript.time += 1;

        Debug.Log("Rest Shelter");
    }

    public void restMotel()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 40;
        lifeScript.Stamina += 40;
        lifeScript.Mood += 40;
        lifeScript.Money -= 40;

        lifeScript.time += 1;

        Debug.Log("Rest Motel");
    }

    public void restHotel()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 80;
        lifeScript.Stamina += 80;
        lifeScript.Mood += 80;
        lifeScript.Money -= 80;

        lifeScript.time += 1;

        Debug.Log("Rest Hotel");
    }

    public void restApartment()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 100;
        lifeScript.Stamina += 100;
        lifeScript.Mood += 100;
        lifeScript.Money -= 100;

        lifeScript.time += 1;

        Debug.Log("Rest Apartment");
    }
}
