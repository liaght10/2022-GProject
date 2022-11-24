using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book4 : MonoBehaviour
{
    public GameObject book1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        book1.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            book1.SetActive(true);
        }
    }

    void OnCollisionExit(Collision Other)
    {
        book1.SetActive(false);
    }
}
