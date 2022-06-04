using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Relic
{
    public RelicInfo relicInfo;

    public Relic() { }

    public Relic(RelicInfo relicInfo) : this()
    {
        this.relicInfo = relicInfo;
    }
}