using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book5 : MonoBehaviour
{
    public GameObject book;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        book.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            book.SetActive(true);
        }
    }

    void OnCollisionExit(Collision Other)
    {
        book.SetActive(false);
    }
}
