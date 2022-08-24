using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectPool<T>
{
     Stack<T> objectPool { get; set; }
     void Clear(); //remove all items
     T Get(); //Get instance from the pool
}
