using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float xpos;
    public float zpos;
    public float ypos;
    public int enemyCount;
    public ParticleSystem spawnEffect;

    private void Start()
    {
        StartCoroutine(EnemyDrop());


    }

    IEnumerator EnemyDrop()
    {
        while (true)
        {
            
            Instantiate(Enemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
            enemyCount += 1;
            spawnEffect.Play();
        }
    }

}
