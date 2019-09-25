using System;
using Unity.Entities;
using Unity.Transforms;

// Serializable attribute is for editor support.
// ReSharper disable once InconsistentNaming
[Serializable]
public struct TranslationSpeed_ForEach : IComponentData
{
    public float speed;
    public LocalToWorld pos;
    
}