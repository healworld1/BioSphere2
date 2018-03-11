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

        stats[metric] += num;
        return true;

    }

	public static void Set(Metric metric, int num) {
		stats [metric] = num; 
	}
}
