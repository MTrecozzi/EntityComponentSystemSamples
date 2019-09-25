using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Unity.Transforms;

// ReSharper disable once InconsistentNaming
[RequiresEntityConversion]
public class TranslationSpeedAuthoring_ForEach : MonoBehaviour, IConvertGameObjectToEntity
{
    public float speed;
    public LocalToWorld translation;

    // The MonoBehaviour data is converted to ComponentData on the entity.
    // We are specifically transforming from a good editor representation of the data (Represented in degrees)
    // To a good runtime representation (Represented in radians)
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        var data = new TranslationSpeed_ForEach { pos =  translation, speed = speed};
        dstManager.AddComponentData(entity, data);
    }
}
