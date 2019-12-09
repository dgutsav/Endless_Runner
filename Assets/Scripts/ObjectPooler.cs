using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool{
        public string tag;
        public GameObject prefab;
        public int size;
    }
    public static ObjectPooler Instance;
    private void Awake(){
        Instance = this;
    }
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    public List<Pool> pools;
    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string,Queue<GameObject>>();

        foreach( Pool pool in pools ){
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for(int i=0;i<pool.size;i++){
                GameObject obj = Instantiate(pool.prefab);
                Debug.Log("Instatiated new "+pool.tag);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag,objectPool);
        }
        //Debug.Log(poolDictionary.ToString());
    }
    public GameObject SpawnFromPool(string tag,Vector3 pos, Vector3 dimensions){
        if(!poolDictionary.ContainsKey(tag)){
            Debug.LogWarning("Pool with tag "+tag+" not found");
            return null;
        }
        GameObject spawnedObject = poolDictionary[tag].Dequeue();
        spawnedObject.SetActive(true);
        spawnedObject.transform.position = pos;
        spawnedObject.transform.localScale = dimensions;
        poolDictionary[tag].Enqueue(spawnedObject);
        return spawnedObject;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
