using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour {

    // Use this for initialization
    public Dictionary<string,int> buildingList;
    float happiness, due;
    int count, lap;

    void Start()
    {
        buildingList = new Dictionary<string, int>();
        happiness = due = 0f;
        count = lap = 0;
    }

    IEnumerator Timer()
    {
        lap++;
        due += 100;
        if (happiness < due)
            print("Mission Failed");
        yield return new WaitForSeconds(120);
    }


	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Timer());


        // calculate hapiness
        happiness = 0f;
        foreach (string key in buildingList.Keys)
        {
            switch (key)
            {
                case "bank":
                    happiness += buildingList["bank"] * 0.15f;
                    break;
                case "factory":
                    happiness += buildingList["factory"] * 0.1f;
                    break;
                case "school":
                    happiness += buildingList["school"] * 0.2f;
                    break;
                case "hospital":
                    happiness += buildingList["hospital"] * 0.2f;
                    break;
                case "park":
                    happiness += buildingList["park"] * 0.15f;
                    break;
                case "house":
                    happiness += buildingList["house"] * 0.2f;
                    break;
            }
        }


	}
}
