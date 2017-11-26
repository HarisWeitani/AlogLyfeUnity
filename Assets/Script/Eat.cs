using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{

    public void eatFromGarbage()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 0;
        lifeScript.Stamina += 10;
        lifeScript.Mood += Random.Range(0,5);
        lifeScript.Hunger += 10;

        lifeScript.time += 1;

        Debug.Log("Eat From Garbage");
    }

    public void eatHotDog()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 10;
        lifeScript.Stamina += 15;
        lifeScript.Mood += Random.Range(0, 10);
        lifeScript.Hunger += 20;
        lifeScript.Money -= 5;

        lifeScript.time += 1;

        Debug.Log("Eat Hot Dog");
    }

    public void eatIceCream()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 15;
        lifeScript.Stamina += 20;
        lifeScript.Mood += Random.Range(0, 20);
        lifeScript.Hunger += 30;
        lifeScript.Money -= 10;

        lifeScript.time += 1;

        Debug.Log("Eat Ice Cream");
    }

    public void eatFoodTruck()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 20;
        lifeScript.Stamina += 30;
        lifeScript.Mood += Random.Range(0, 30);
        lifeScript.Hunger += 40;
        lifeScript.Money -= 20;

        lifeScript.time += 1;

        Debug.Log("Eat Ice Cream");
    }

    public void eatRestaurant()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 25;
        lifeScript.Stamina += 40;
        lifeScript.Mood += Random.Range(0, 40);
        lifeScript.Hunger += 50;
        lifeScript.Money -= 40;

        lifeScript.time += 1;

        Debug.Log("Eat Restaurant");
    }

    public void eat5StarHotel()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Health += 100;
        lifeScript.Stamina += 100;
        lifeScript.Mood += Random.Range(0, 100);
        lifeScript.Hunger += 100;
        lifeScript.Money -= 80;

        lifeScript.time += 1;

        Debug.Log("Eat 5 Star Hotel");
    }
}
