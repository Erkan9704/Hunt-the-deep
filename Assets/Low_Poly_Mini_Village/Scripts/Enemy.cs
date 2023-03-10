using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent enemy;

    public Transform PlayerTarget;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTarget = GameObject.FindWithTag("Player").transform;
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerTarget.position);
    }

}
