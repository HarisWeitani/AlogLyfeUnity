using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAspect : MonoBehaviour
{

    public int Health, Stamina, Mood, Hunger, Money;
    public int Math, Science, Business;
    public int Thief, GunHandling, Hacking;
    private int maxLifeLevel = 1;
    public bool policeRaid;
    public int time;

    // Use this for initialization
    void Start()
    {
        Health = Random.Range(30, 100);
        Stamina = Random.Range(10, 100);
        Mood = Random.Range(10, 100);
        Hunger = Random.Range(10, 100);
        Money = Random.Range(0, 20);
        Math = Science = Business = Thief = GunHandling = Hacking = 0;
        policeRaid = false;
        time = Random.Range(9, 15);
    }

    // Update is called once per frame
    void Update()
    {
//        forTestingPurpose();

        maxLifeCheck();
        timeCheck();
    }

    private void timeCheck()
    {
        if(time == 24)
        {
            time = 0;
        }
    }

    private void maxLifeCheck()
    {
        if (maxLifeLevel == 1)
        {
            maxLifeAspectStandart();
        }
        else if (maxLifeLevel == 2)
        {
            maxLifeAspectPlus1();
        }
        else if (maxLifeLevel == 3)
        {
            maxLifeAspectPlus2();
        }
        else if (maxLifeLevel == 4)
        {
            maxLifeAspectPlus3();
        }
        else if (maxLifeLevel == 5)
        {
            maxLifeAspectPlus4();
        }
        else if (maxLifeLevel == 6)
        {
            maxLifeAspectPlusUltra();
        }
    }

    //max 100
    private void maxLifeAspectStandart()
    {
        maxLifeLevel = 1;
        if (Health > 100)
        {
            Health = 100;
            Debug.Log("Max HP");
        }
        if (Stamina > 100)
        {
            Stamina = 100;
            Debug.Log("Max Stamina");
        }
        if (Mood > 100)
        {
            Mood = 100;
            Debug.Log("Max Mood");
        }
        if (Hunger > 100)
        {
            Hunger = 100;
            Debug.Log("Max Hunger");
        }
    }

    //max 110
    private void maxLifeAspectPlus1()
    {
        maxLifeLevel = 2;
        if (Health > 110)
        {
            Health = 110;
            Debug.Log("Max HP");
        }
        if (Stamina > 110)
        {
            Stamina = 110;
            Debug.Log("Max Stamina");
        }
        if (Mood > 110)
        {
            Mood = 110;
            Debug.Log("Max Mood");
        }
        if (Hunger > 110)
        {
            Hunger = 110;
            Debug.Log("Max Hunger");
        }
    }

    //max 120
    private void maxLifeAspectPlus2()
    {
        maxLifeLevel = 3;
        if (Health > 120)
        {
            Health = 120;
            Debug.Log("Max HP");
        }
        if (Stamina > 120)
        {
            Stamina = 120;
            Debug.Log("Max Stamina");
        }
        if (Mood > 120)
        {
            Mood = 120;
            Debug.Log("Max Mood");
        }
        if (Hunger > 120)
        {
            Hunger = 120;
            Debug.Log("Max Hunger");
        }
    }

    //max 140
    private void maxLifeAspectPlus3()
    {
        maxLifeLevel = 4;
        if (Health > 140)
        {
            Health = 140;
            Debug.Log("Max HP");
        }
        if (Stamina > 140)
        {
            Stamina = 140;
            Debug.Log("Max Stamina");
        }
        if (Mood > 140)
        {
            Mood = 140;
            Debug.Log("Max Mood");
        }
        if (Hunger > 140)
        {
            Hunger = 140;
            Debug.Log("Max Hunger");
        }
    }

    //max 150
    private void maxLifeAspectPlus4()
    {
        maxLifeLevel = 5;
        if (Health > 150)
        {
            Health = 150;
            Debug.Log("Max HP");
        }
        if (Stamina > 150)
        {
            Stamina = 150;
            Debug.Log("Max Stamina");
        }
        if (Mood > 150)
        {
            Mood = 150;
            Debug.Log("Max Mood");
        }
        if (Hunger > 150)
        {
            Hunger = 150;
            Debug.Log("Max Hunger");
        }
    }

    //max 300
    private void maxLifeAspectPlusUltra()
    {
        maxLifeLevel = 6;
        if (Health > 300)
        {
            Health = 300;
            Debug.Log("Max HP");
        }
        if (Stamina > 300)
        {
            Stamina = 300;
            Debug.Log("Max Stamina");
        }
        if (Mood > 300)
        {
            Mood = 300;
            Debug.Log("Max Mood");
        }
        if (Hunger > 300)
        {
            Hunger = 300;
            Debug.Log("Max Hunger");
        }
    }

    void forTestingPurpose()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Health += 10;
            Mood += 10;
        }
    }

}
