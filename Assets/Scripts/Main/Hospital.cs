using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital: Building
{
    public static int Population { get; private set; }
    public static int Health { get; private set; }
    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, -500);
        Stats.AddTo(Stats.Metric.traffic, -5);
        Stats.AddTo(Stats.Metric.availableSpace, -2);
        Stats.AddTo(Stats.Metric.energy, -40);
        Stats.AddTo(Stats.Metric.population, 3);
        Stats.AddTo(Stats.Metric.health, 10);
        base.Build();
    }
    public void Start()
    {

        Money = -500;
        Traffic = -5;
        AvailableSpace = -2;
        Energy = -40;
        Population = 3;
        Health = 10;
        Color = Color.white;
    }

}
