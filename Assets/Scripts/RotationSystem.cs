using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class RotationSystem : ComponentSystem
{
    private EntityQuery _cubes;

    protected override void OnCreateManager()
    {
        _cubes = Entities
            .WithAll<RotationSpeed, Rotation>()
            .ToEntityQuery();
    }

    protected override void OnUpdate()
    {
        Entities.With(_cubes).ForEach((ref RotationSpeed rotationSpeed, ref Rotation rotation) =>
        {
            rotation.Value = math.mul(rotation.Value,
                quaternion.RotateY(
                    math.radians(rotationSpeed.DegreesPerSecond * Time.deltaTime)
                )
            );
        });
    }
}