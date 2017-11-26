using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{

    void studyStatusManager()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Stamina -= 15;
        lifeScript.Mood -= 15;
        lifeScript.Hunger -= 15;

    }

    public void studyMath()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 100;
        lifeScript.Math += 1;
        lifeScript.time += 1;

        Debug.Log("Study Math");
    }
    public void studyScience()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 100;
        lifeScript.Science += 1;
        lifeScript.time += 1;

        Debug.Log("Study Science");
    }
    public void studyBusiness()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 100;
        lifeScript.Business += 1;
        lifeScript.time += 1;

        Debug.Log("Study Business");
    }
    public void studyThief()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 50;
        lifeScript.Thief += 1;
        lifeScript.time += 1;

        Debug.Log("Study Thief");
    }
    public void studyGunHandling()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 50;
        lifeScript.GunHandling += 1;
        lifeScript.time += 1;

        Debug.Log("Study Gun Handling");
    }
    public void studyHacking()
    {
        studyStatusManager();
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        lifeScript.Money -= 150;
        lifeScript.Hacking += 1;
        lifeScript.time += 1;

        Debug.Log("Study Hacking");
    }

}
