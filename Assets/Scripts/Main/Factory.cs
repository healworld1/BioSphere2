using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building {
    public int Population { get; private set; }

    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, 500);
        Stats.AddTo(Stats.Metric.traffic, 13);
        Stats.AddTo(Stats.Metric.availableSpace, -1);
        Stats.AddTo(Stats.Metric.energy, -10);
        Stats.AddTo(Stats.Metric.population, 10);
        base.Build();
    }

    public void Start()
    {
        Money = -500;
        Traffic = 13;
        AvailableSpace = -1;
        Energy = 10;
        Population = 10;
        Color = Color.red;
    }
}
