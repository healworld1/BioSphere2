using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : Building
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
        Stats.AddTo(Stats.Metric.traffic, -10);

        return base.Build();
    }
    public void Start()
    {
        Money = -200;
        Traffic = -10;
        AvailableSpace = -2;
        Energy = -50;
        Color = Color.gray;
    }

}
