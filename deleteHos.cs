using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteHos : MonoBehaviour
{
    public GameObject hos;
    public GameObject sand1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            hos.SetActive(false);
            sand1.SetActive(false);
        }
    }



    }

