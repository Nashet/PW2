using Unity.Collections;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    public struct StorageElement : IBufferElementData
    { 
        public readonly FixedString64 Id;
        public int Count;
        public int delData;
         
        public StorageElement(string id) {
            this.Id = id;
            this.Count = 1;
            delData = 7;
        }
 
        public StorageElement(string id, int count)  : this(id){
            this.Count = count;
        }
    }
}