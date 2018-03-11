using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour{
	public virtual bool Build()
    {
        transform.parent.parent.GetComponent<InitialCity>().UpdateStats();
        return true;
    } 
    public int Traffic { get; protected set; }
    public int AvailableSpace { get; protected set; }   // return the size a building will occupied
    public int Money { get; protected set; }  // return the cost of the buildling;
    public int Energy { get; protected set; }  // return the cost of building that building energy will take;
    public virtual Color Color { get; protected set; }
}