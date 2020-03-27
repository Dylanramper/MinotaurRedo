using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //Create a list to store enemies
    List<GameObject> Enemies = new List<GameObject>();

    public GameObject Ghost;
    public GameObject Wolf;
    public GameObject Rat;
     
    void Start()
    {
        //Add enemies to list
        Enemies.Add(Ghost);
        Enemies.Add(Wolf);
        Enemies.Add(Rat);

        Wolf.GetComponent<BoxCollider2D>().enabled = true;

        //Repeat the spawner every 3 seconds
        InvokeRepeating("SpawnEnemy", 3f, 3f);
    }

    //spawn a random enemy from the list
    void SpawnEnemy()
    {
        int EnemyIndex = Random.Range(0, Enemies.Count);
        Instantiate(Enemies[EnemyIndex]);
    }
}
