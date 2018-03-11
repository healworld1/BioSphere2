using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Header : MonoBehaviour {
	GameObject obj; 

	// Use this for initialization
	void Start () {
		obj = transform.GetChild (0).gameObject; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UpdateText() {
		string str = Stats.SerializeText();
		obj.GetComponent<Text> ().text = str; 
	}
}
