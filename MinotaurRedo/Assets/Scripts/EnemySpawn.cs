using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    List<GameObject> Enemies = new List<GameObject>();

    public GameObject Ghost;
    public GameObject Wolf;
    public GameObject Rat;

    //float spawnSpeed = 3f;
     
    void Start()
    {
        Enemies.Add(Ghost);
        Enemies.Add(Wolf);
        Enemies.Add(Rat);

        InvokeRepeating("SpawnEnemy", 3f, 3f);
    }
    
    void Update()
    {

    }

    void SpawnEnemy()
    {
        int EnemyIndex = Random.Range(0, Enemies.Count - 1);
        Instantiate(Enemies[EnemyIndex]);
    }
    
}
