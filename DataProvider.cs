using System;
using UnityEngine;
using System.Reflection;
using System.Collections;

namespace binc.Common{

    [Serializable]
    public class BaseData{
    
    }

    // [Serializable]
    // public struct GenericData{
    //     [SerializeReference] private BaseData baseData;

    //     public GenericData(BaseData baseData){
    //         this.baseData = baseData;
    //     }
        
        
    // }


    [Serializable]
    public class Data<T> : BaseData{
        public T data;
        public override bool Equals(object obj){
            if(obj is null || obj is not Data<T>)
                return false;
            return data.Equals(((Data<T>)obj).data);
        }

        public override int GetHashCode(){
            return data.GetHashCode();
        }
    }

}