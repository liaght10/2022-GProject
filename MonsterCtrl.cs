using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{

    private Transform monsterTr;
    private Transform playerTr;
    private NavMeshAgent agent;
   static public bool touched = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (touched == true)
        {
            monsterTr = GetComponent<Transform>();
            playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            agent = GetComponent<NavMeshAgent>();
            agent.destination = playerTr.position;
        }
    }
}


   
