using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : Building
{
    public int Population { get; private set; }
    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, 1000);
        Stats.AddTo(Stats.Metric.traffic, 7);
        Stats.AddTo(Stats.Metric.availableSpace, -2);
        Stats.AddTo(Stats.Metric.energy, -75);
        Stats.AddTo(Stats.Metric.population, 5);
        base.Build();
    }

    public void Start()
    {
        Money = -1000;
        Traffic = 7;
        AvailableSpace = -1;
        Energy = -75;
        Population = 5;
        Color = Color.yellow;
    }
}
