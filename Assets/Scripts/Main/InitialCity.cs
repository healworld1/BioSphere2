
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialCity : MonoBehaviour
{
    public Dictionary<Type, int> buildingList;
    public int Energy
    {
        get
        {
            return Stats.stats[Stats.Metric.energy];
        }
        set
        {
            Stats.Set(Stats.Metric.energy, value);
        }
    }
    public int Money
    {
        get
        {
            return Stats.stats[Stats.Metric.money];
        }
        set
        {
            Stats.Set(Stats.Metric.money, value);
        }
    }
    public int Space
    {
        get
        {
            return Stats.stats[Stats.Metric.availableSpace];
        }
        set
        {
            Stats.Set(Stats.Metric.availableSpace, value);
        }
    }
    public int Traffic
    {
        get
        {
            return Stats.stats[Stats.Metric.traffic];
        }
        set
        {
            Stats.Set(Stats.Metric.traffic, value);
        }
    }
    public int Health
    {
        get
        {
            return Stats.stats[Stats.Metric.health];
        }
        set
        {
            Stats.Set(Stats.Metric.health, value);
        }
    }
    public int Environment
    {
        get
        {
            return Stats.stats[Stats.Metric.environment];
        }
        set
        {
            Stats.Set(Stats.Metric.environment, value);
        }
    }
    public int Population
    {
        get
        {
            return Stats.stats[Stats.Metric.population];
        }
        set
        {
            Stats.Set(Stats.Metric.population, value);
        }
    }

    float due = 100;

    public double Happiness()
    {
        return (
            Stats.stats[Stats.Metric.health] * 1.5 +
            Stats.stats[Stats.Metric.environment] * 3 +
            Stats.stats[Stats.Metric.traffic] * -1.1);

        // TO-DO click a building, add to dictionary
    }
    public double ClacStats()
    {


        foreach (Type key in buildingList.Keys)
        {
            if (key.GetType() == typeof(Bank))
            {
                Traffic += buildingList[key] * Bank.Traffic;
            }
            if (key.GetType() == typeof(Factory))
            {
                Traffic += buildingList[key] * Factory.Traffic;
            }
            if (key.GetType() == typeof(Hospital))
            {
                Traffic += buildingList[key] * Hospital.Traffic;
                Health += buildingList[key] * Hospital.Health;
            }
            if (key.GetType() == typeof(Park))
            {
                Traffic += buildingList[key] * Park.Traffic;
                Health += buildingList[key] * Park.Health;
            }
            if (key.GetType() == typeof(Road))
            {
                Traffic += buildingList[key] * Road.Traffic;
            }
            if (key.GetType() == typeof(House))
            {
                Traffic += buildingList[key] * House.Traffic;
            }

        }
        return Health * 0.2 + Environment * 0.2 - 0.1 * Traffic;
    }

    public bool WinElection()
    {
        due += 100;
        return Happiness() > due;
    }

    // Use this for initialization
    void Start()
    {
        buildingList = new Dictionary<Type, int>
        {
            { typeof(Bank), 0 },
            { typeof(Factory), 0 },
            { typeof(Hospital), 0 },
            { typeof(Park), 0 },
            { typeof(Road), 0 },
            { typeof(House), 0 }
        };
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateStats()
    {
        Transform header = transform.Find("Header");
        header.transform.Find("Money").GetComponent<Text>().text = "Money: " + Money;
        header.transform.Find("Energy").GetComponent<Text>().text = "Energy: " + Energy;
        header.transform.Find("Health").GetComponent<Text>().text = "Health: " + Health;
        header.transform.Find("Population").GetComponent<Text>().text = "Pop: " + Population;
        header.transform.Find("Environment").GetComponent<Text>().text = "Env: " + Environment;
        header.transform.Find("AvailableSpace").GetComponent<Text>().text = "Space: " + Space;
        header.transform.Find("Traffic").GetComponent<Text>().text = "Traffic: " + Traffic;
        header.transform.Find("Happiness").GetComponent<Text>().text = "Happiness: " + Happiness();
    }
}