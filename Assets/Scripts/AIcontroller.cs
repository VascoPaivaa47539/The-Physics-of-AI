﻿using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    public GameObject goal;
    NavMeshAgent agent;

    
    void Start()
    {
        
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.transform.position);
    }
}

