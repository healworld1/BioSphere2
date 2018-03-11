using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building {
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
        Stats.AddTo(Stats.Metric.traffic, 13);
        Stats.AddTo(Stats.Metric.population, 10);
        return base.Build();
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
