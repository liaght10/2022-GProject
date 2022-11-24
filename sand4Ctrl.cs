using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sand4Ctrl : MonoBehaviour
{


    private Transform monsterTr;
    private Transform playerTr;
    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        monsterTr = GetComponent<Transform>();
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = playerTr.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
