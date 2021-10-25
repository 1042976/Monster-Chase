using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] MonsterReference;

    [SerializeField]
    private Transform[] Pos;

    private GameObject spawnedMonster;

    private int randomIndex, randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnMonsters() {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, MonsterReference.Length);
            randomSide = Random.Range(0, 2);
            spawnedMonster = Instantiate(MonsterReference[randomIndex]);
            spawnedMonster.transform.position = Pos[randomSide].position;
            spawnedMonster.GetComponent<Monster>().speed = (randomSide == 0 ? 1 : -1) * Random.Range(5, 12);
        }
    }

    
}
