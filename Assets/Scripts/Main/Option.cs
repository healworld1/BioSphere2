using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    // Use this for initialization
    public string Name { get; private set; }
    public string[] Types { get; private set; }

    public Option(string name, params string[] types)
    {
        Name = name;
        Types = types;
    }

    public void Select()
    {
        foreach (string type in Types) {
            switch (type) {
                case "Money":
                    break;
                case "UnlockBuilding":
                    break;
                case "Destruction":
                    break;
                case "Happiness":
                    break;
            }
        }
    }
}
