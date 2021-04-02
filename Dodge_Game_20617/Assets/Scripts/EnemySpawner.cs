using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy enemy;
    public GameObject enemyGroup;
    private bool isPlaying = true;

    public void offSpawner()
    {
        isPlaying = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spawnPer = Random.Range(0, 1001);
        if (spawnPer < 100)
        {
            Enemy e = Instantiate(enemy);

            float posY = Random.Range(-4.5f, 4.5f);
            int isLeftInstantiate = Random.Range(0, 2);

            if (isLeftInstantiate == 0)
            {
                e.transform.position = new Vector3(-9f, posY, -1);
                e.transform.rotation = new Quaternion(0, 0, 0, 0);
                e.SetDirectionVector(1);
            }
            else
            {
                e.transform.position = new Vector3(9f, posY, -1);
                e.transform.rotation = new Quaternion(0, 0, 180, 0);
                e.SetDirectionVector(-1);
            }
            e.transform.parent = enemyGroup.transform;
        }
    }
}
