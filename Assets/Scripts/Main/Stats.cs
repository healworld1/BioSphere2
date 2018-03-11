using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour{
	public static Dictionary<Metric, int> stats; 
	public enum Metric { 
		energy, 
		availableSpace, 
		traffic, 
		health, 
		environment, 
		population, 
		money, 
		happiness
	}

	// Use this for initialization
	void Start () {
        
		stats = new Dictionary<Metric, int> () {
			{ Metric.energy, 900 }, 
			{ Metric.availableSpace, 100 }, 
			{ Metric.traffic, 5 }, 
			{ Metric.health, 5 }, 
			{ Metric.environment, 5 }, 
			{ Metric.population, 1 }, 
			{ Metric.money, 9000 }, 
			{ Metric.happiness, 25 }
		};
        GetComponent<InitialCity>().UpdateStats();
	}

	public static bool AddTo(Metric metric, int num) {
        if (stats[metric] + num < 0)
        {
            return false;
        }
        //print(stats[metric]);
        //print(num);
        stats[metric] += num;
        return true;

    }

	public static void Set(Metric metric, int num) {
		stats [metric] = num; 
	}

	public static string SerializeText()
	{
		string str = "Energy: " + stats [Metric.energy] +
		    "\tSpace: " + stats [Metric.availableSpace] +
			"\tTraffic: " + stats [Metric.traffic] +
			"\tHealth: " + stats [Metric.health] +
			"\tEnvironment: " + stats [Metric.environment] +
			"\tPopulation: " + stats [Metric.population] +
			"\tMoney: " + stats [Metric.money] +
			"\tHappiness: " + stats [Metric.happiness]; 

		return str; 
	}

	// Update is called once per frame
	static void Update () {
		
	}
}
