using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletPool : MonoBehaviour
{
    private IObjectPool<GameObject> basicBulletPool;
    [SerializeField]private ObjectPooler objectPooler;
    [SerializeField] private GameObject player;
    public GameObject bullet;
    public int numberOfBullets;
    public GameObject bulletCurr;

    private Stack<GameObject> instantiatedPoolObjects;

    public void Awake()
    {
        objectPooler = GetComponent<ObjectPooler>();
        basicBulletPool = objectPooler;
        basicBulletPool.objectPool = new Stack<GameObject>();
        instantiatedPoolObjects = new Stack<GameObject>();
        for (int i = 0; i < numberOfBullets; i++)
        {
            basicBulletPool.objectPool.Push(bullet);
            var currentBullet = Instantiate(basicBulletPool.Get(),Vector3.zero,Quaternion.identity);
            basicBulletPool.objectPool.Push(currentBullet);
            currentBullet.SetActive(false);
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var newBullet = basicBulletPool.objectPool.Pop();
            newBullet.SetActive(true);
            newBullet.transform.position = player.transform.position + (Vector3.right * 3);          
        }
    }
}
