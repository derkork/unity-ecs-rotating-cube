using System;
using Unity.Entities;

[Serializable]
public struct RotationSpeed : IComponentData
{
    // ReSharper disable once InconsistentNaming
    public float DegreesPerSecond;
}

