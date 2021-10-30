using System;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    [Serializable]
    public struct ParentComponent : IComponentData
    {
        public Entity Parent;
        public int Id;
    }
    
    [Serializable]
    public struct CountryComponent : IComponentData
    {
        
    }
}