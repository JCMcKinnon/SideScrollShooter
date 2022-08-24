using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPooler : MonoBehaviour, IObjectPool<GameObject>
{

    public Stack<GameObject> objectPool { get ; set; }

    public void Clear()
    {
        objectPool.Clear();
    }

    public GameObject Get()
    {
        
        if(objectPool.Count != 0)
        {          
            return objectPool.Pop();            
        }
        return null;
    }


}
