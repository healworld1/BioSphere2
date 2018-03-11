using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : Building
{
    public int Population { get; private set; }
    public override bool Build()
    {
        if (!Stats.AddTo(Stats.Metric.money, Money))
        {
            return false;
        }
        if (!Stats.AddTo(Stats.Metric.availableSpace, AvailableSpace))
        {
            return false;
        }
        if (!Stats.AddTo(Stats.Metric.energy, Energy))
        {
            return false;
        }
        Stats.AddTo(Stats.Metric.traffic, 7);
        Stats.AddTo(Stats.Metric.population, 5);
        return base.Build();
    }

    public void Start()
    {
        Money = 1000;
        Traffic = 7;
        AvailableSpace = -2;
        Energy = -75;
        Population = 5;
        Color = Color.yellow;
    }
}
