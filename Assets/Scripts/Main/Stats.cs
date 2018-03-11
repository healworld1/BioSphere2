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
			{ Metric.energy, 50 }, 
			{ Metric.availableSpace, 100 }, 
			{ Metric.traffic, 5 }, 
			{ Metric.health, 5 }, 
			{ Metric.environment, 5 }, 
			{ Metric.population, 1 }, 
			{ Metric.money, 500 }, 
			{ Metric.happiness, 25 }
		}; 
	}

	public static void AddTo(Metric metric, int num) {
		stats [metric] += num; 
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
