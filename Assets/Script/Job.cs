using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{

    public void halalBeg()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        if (lifeScript.time >= 6 && lifeScript.time <= 18) {
            lifeScript.Health -= 10;
            lifeScript.Stamina -= 10;
            lifeScript.Mood -= 5;
            lifeScript.Hunger -= 10;
            lifeScript.Money += Random.Range(0, 5);

            lifeScript.time += 1;

            Debug.Log("Job Halal Beg");
        }
        else
        {
            return;
        }
    }

    public void halalLaborWork()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();
        if (lifeScript.time >= 6 && lifeScript.time < 18)
        {
            lifeScript.Health -= 5;
            lifeScript.Stamina -= 20;
            lifeScript.Mood -= 5;
            lifeScript.Hunger -= 15;
            lifeScript.Money += 10;

            lifeScript.time += 1;

            Debug.Log("Job Halal LaborWork");
        }
    }

    public void halalCashier()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();
        if (lifeScript.time >= 6 && lifeScript.time < 18)
        {
            if (lifeScript.Math >= 1 && lifeScript.Business >= 1)
            {
                lifeScript.Health -= 5;
                lifeScript.Stamina -= 10;
                lifeScript.Mood -= 5;
                lifeScript.Hunger -= 10;
                lifeScript.Money += 15;

                lifeScript.time += 1;

                Debug.Log("Job Halal Cashier");
            }
            else
            {
                return;
            }
        }
        else
        {
            return;
        }

    }

    public void halalHappyCubicleJob()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();
        if (lifeScript.time >= 6 && lifeScript.time < 18)
        {
            if (lifeScript.Math >= 3 && lifeScript.Business >= 2 && lifeScript.Science >= 2)
            {
                lifeScript.Health -= 5;
                lifeScript.Stamina -= 10;
                lifeScript.Mood -= 20;
                lifeScript.Hunger -= 10;
                lifeScript.Money += 30;

                lifeScript.time += 1;

                Debug.Log("Job Halal Happy Cubicle Job");
            }
            else
            {
                return;
            }
        }
    }

    public void halalBossOfCubicleJob()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();
        if (lifeScript.time >= 6 && lifeScript.time < 18)
        {
            if (lifeScript.Math >= 5 && lifeScript.Business >= 5 && lifeScript.Science >= 5)
            {
                lifeScript.Health -= 5;
                lifeScript.Stamina -= 5;
                lifeScript.Mood -= 10;
                lifeScript.Hunger -= 10;
                lifeScript.Money += 50;

                lifeScript.time += 1;

                Debug.Log("Job Halal Boss Of Cubiblce Job");
            }
            else
            {
                return;
            }
        }
    }

    //un Halal Job
    private int tempRaid;

    public void unHalalRobberyInTheAlley()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        if (lifeScript.time >= 18 && lifeScript.time < 6)
        {
            tempRaid = Random.Range(1, 10);
            lifeScript.policeRaid = false;

            if (lifeScript.Thief >= 1 && lifeScript.GunHandling >= 1)
            {
                if (tempRaid == 1)
                {
                    lifeScript.policeRaid = true;
                    lifeScript.time += 12;

                    Debug.Log("Busted");
                }
                else
                {
                    lifeScript.policeRaid = false;
                    lifeScript.Health -= Random.Range(0, 10);
                    lifeScript.Stamina -= Random.Range(1, 20);
                    lifeScript.Mood -= 25;
                    lifeScript.Hunger -= 10;
                    lifeScript.Money += Random.Range(0, 50);

                    lifeScript.time += 1;

                    Debug.Log("Job unHalal Robbery in the Alley");
                }
            }
            else
            {
                return;
            }
        }
    }
    public void unHalalHackATM()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        if (lifeScript.time >= 18 && lifeScript.time < 6)
        {
            tempRaid = Random.Range(1, 4);
            lifeScript.policeRaid = false;

            if (lifeScript.Math >= 5 && lifeScript.Business >= 3 && lifeScript.Science >= 3 && lifeScript.Hacking >= 5)
            {
                if (tempRaid == 1)
                {
                    lifeScript.policeRaid = true;
                    Debug.Log("Busted");
                    lifeScript.time += 12;
                }
                else
                {
                    lifeScript.policeRaid = false;
                    lifeScript.Health -= 0;
                    lifeScript.Stamina -= Random.Range(20, 50);
                    lifeScript.Mood -= 50;
                    lifeScript.Hunger -= 50;
                    lifeScript.Money += Random.Range(100, 1000);

                    lifeScript.time += 3;

                    Debug.Log("Job unHalal Hack ATM");
                }
            }
            else
            {
                return;
            }
        }
    }

    public void unHalalBankRobbery()
    {
        GameObject lifeAspect = GameObject.Find("LifeAspect");
        LifeAspect lifeScript = lifeAspect.GetComponent<LifeAspect>();

        if (lifeScript.time >= 18 && lifeScript.time < 6)
        {
            tempRaid = Random.Range(1, 2);
            lifeScript.policeRaid = false;

            if (lifeScript.Math >= 3 && lifeScript.Thief >= 5 && lifeScript.GunHandling >= 5 && lifeScript.Hacking >= 3)
            {
                if (tempRaid == 1)
                {
                    lifeScript.policeRaid = true;
                    Debug.Log("Busted");
                    lifeScript.time += 12;

                }
                else
                {
                    lifeScript.policeRaid = false;
                    lifeScript.Health -= Random.Range(20, 80);
                    lifeScript.Stamina -= Random.Range(70, 100);
                    lifeScript.Mood -= 50;
                    lifeScript.Hunger -= 50;
                    lifeScript.Money += Random.Range(500, 10000);

                    lifeScript.time += 6;

                    Debug.Log("Job unHalal Bank Robbery");
                }
            }
            else
            {
                return;
            }
        }
    }
}