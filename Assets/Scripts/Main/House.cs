using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
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
        Stats.AddTo(Stats.Metric.population, 8);
        return base.Build();
    }
    public int Population { get; private set; }
    public void Start()
    {
        Money = -200;
        Traffic = 7;
        AvailableSpace = -1;
        Energy = -7;
        Population = 8;
        Color = Color.blue;
    }
}
