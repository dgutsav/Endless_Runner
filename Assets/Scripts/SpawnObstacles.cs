using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    ObjectPooler objectPooler;
    public GameObject obstacle_prefab;
    public float spawnTime = 2.0f;
    public float render_distance = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        StartCoroutine(spawnRoutine());
        
    }
    private void spawnObstacles(){
        float size_x = Random.Range(0.1f,2f);
        float size_y = Random.Range(0.1f,2f);
        float size_z = Random.Range(0.1f,2f);
        float pos_y = (size_y/2)+0.5f;
        float pos_x = Random.Range(-5f,5f);
        Vector3 pos = new Vector3(pos_x,pos_y,render_distance);
        Vector3 size = new Vector3(size_x,size_y,size_z);  
        objectPooler.SpawnFromPool("obstacle",pos,size); 
    }
    IEnumerator spawnRoutine(){
        while(true){
            yield return new WaitForSeconds(spawnTime);
            spawnObstacles();
        }
    }
    // Update is called once per frame
    void Update(){
        
    }
}
