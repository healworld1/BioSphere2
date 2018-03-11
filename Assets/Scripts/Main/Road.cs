using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : Building
{
    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, -200);
        Stats.AddTo(Stats.Metric.traffic, 10);
        Stats.AddTo(Stats.Metric.availableSpace, -2);
        Stats.AddTo(Stats.Metric.energy, -50);
        base.Build();
    }
    public void Start()
    {
        Money = -200;
        Traffic = 10;
        AvailableSpace = -2;
        Energy = -50;
        Color = Color.gray;
    }

}
