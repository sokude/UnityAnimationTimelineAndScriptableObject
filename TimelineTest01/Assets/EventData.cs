using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EventData : ScriptableObject
{
    [SerializeField] private int intdata;
    [SerializeField] private float floatdata;

    public int Intdata { get => intdata; set => intdata = value; }
    public float Floatdata { get => floatdata; set => floatdata = value; }
}
