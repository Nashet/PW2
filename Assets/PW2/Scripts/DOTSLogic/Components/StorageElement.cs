using Unity.Collections;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    public struct StorageElement : IBufferElementData
    { 
        public readonly FixedString64 Id;
        public decimal Amount;

        public StorageElement(FixedString64 id) {
            this.Id = id;
            this.Amount = 1;
        }
 
        public StorageElement(FixedString64 id, decimal count)  : this(id){
            this.Amount = count;
        }
    }
}