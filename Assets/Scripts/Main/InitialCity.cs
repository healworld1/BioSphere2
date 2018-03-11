using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialCity : MonoBehaviour {
    Dictionary<Building, int> buildingList;
    public int Energy {
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
            Stats.Set(Stats.Metric.energy, value);
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
            Stats.Set(Stats.Metric.energy, value);
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
            Stats.Set(Stats.Metric.energy, value);
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
            Stats.Set(Stats.Metric.energy, value);
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
            Stats.Set(Stats.Metric.energy, value);
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
            Stats.Set(Stats.Metric.energy, value);
        }
    }

    float due = 100;

    public double Happiness()
    {
        return (
            Stats.stats[Stats.Metric.health] * 0.2 +
            Stats.stats[Stats.Metric.environment] * 0.2 -
            Stats.stats[Stats.Metric.traffic] * -0.1);

        // TO-DO click a building, add to dictionary
    }
    public double ClacStats()
    {


        foreach (Building key in buildingList.Keys)
        {
            if (key.GetType() == typeof(Bank))
            {
                Traffic += buildingList[key] * ((Bank)key).Traffic;
            }
            if (key.GetType() == typeof(Factory))
            {
                Traffic += buildingList[key] * ((Factory)key).Traffic;
            }
            if (key.GetType() == typeof(Hospital))
            {
                Traffic += buildingList[key] * ((Hospital)key).Traffic;
                Health += buildingList[key] * ((Hospital)key).Health;
            }
            if (key.GetType() == typeof(Park))
            {
                Traffic += buildingList[key] * ((Park)key).Traffic;
                Health += buildingList[key] * ((Park)key).Health;
            }
            if (key.GetType() == typeof(Road))
            {
                Traffic += buildingList[key] * ((Road)key).Traffic;
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
        buildingList = new Dictionary<Building, int>();
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
    }
}
