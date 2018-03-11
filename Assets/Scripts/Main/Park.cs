using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Park : Building {
    public int Traffic { get; private set; }

    public int Population { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public override void Build()
    {
        Stats.AddTo(Stats.Metric.money, -700);
        Stats.AddTo(Stats.Metric.traffic, -10);
        Stats.AddTo(Stats.Metric.availableSpace, -5);
        Stats.AddTo(Stats.Metric.energy, -10);
        Stats.AddTo(Stats.Metric.population, 7);
        Stats.AddTo(Stats.Metric.happiness, 5);
        Stats.AddTo(Stats.Metric.health, 3);
        base.Build();
    }

    public void Start()
    {
        Money = -700;
        Traffic = -10;
        AvailableSpace = -5;
        Energy = -10;
        Population = 15;
        Happiness = 5;
        Color = Color.cyan;
    }
}
