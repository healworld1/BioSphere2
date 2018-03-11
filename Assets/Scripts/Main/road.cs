using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : Building {
    public int Traffic { get; private set; }
	public void Start()
    {
        Money = -200;
        Traffic = 10;
        AvailableSpace = -2;
        Energy = -50;
        Color = Color.gray;
	}
       
}
