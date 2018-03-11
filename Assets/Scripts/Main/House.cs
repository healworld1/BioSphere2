using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, -200);
        Stats.AddTo(Stats.Metric.traffic, -15);
        Stats.AddTo(Stats.Metric.availableSpace, -1);
        Stats.AddTo(Stats.Metric.energy, -7);
        Stats.AddTo(Stats.Metric.population, 8);
        base.Build();
    }
    public int Population { get; private set; }
    public void Start()
    {
        Money = -200;
        Traffic = -15;
        AvailableSpace = -1;
        Energy = -7;
        Population = 8;
        Color = Color.blue;
    }
}
