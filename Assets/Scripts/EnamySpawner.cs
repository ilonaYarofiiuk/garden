using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamySpawner : MonoBehaviour
{

    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] Enamy[] enamyPrefabArray;
    bool spawn = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttackers();
        }
    }

    private void SpawnAttackers()
    {
        int enemyIndex = Random.Range(0, enamyPrefabArray.Length);
        Spawn(enamyPrefabArray[enemyIndex]);
    }

    private void Spawn(Enamy enemy)
    {
        Enamy newEnamy = Instantiate(enemy, transform.position, Quaternion.identity);
    }

    public void StopSpawn()
    {
        spawn = false;
    }
} 