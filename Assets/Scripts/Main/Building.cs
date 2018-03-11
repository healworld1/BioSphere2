using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour{
	public virtual void Build()
    {
        transform.parent.parent.GetComponent<InitialCity>().UpdateStats();
    } 
    public static int Traffic { get; protected set; }
    public static int AvailableSpace { get; protected set; }   // return the size a building will occupied
    public static int Money { get; protected set; }  // return the cost of the buildling;
    public static int Energy { get; protected set; }  // return the cost of building that building energy will take;
    public virtual Color Color { get; protected set; }
}