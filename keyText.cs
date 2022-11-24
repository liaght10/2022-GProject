using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class keyText : MonoBehaviour
{

    private Text KeyText;
    private int key = 0;


    // Start is called before the first frame update
    void Start()
    {
        KeyText = GetComponent<Text>();
        key = 3;
    }

    // Update is called once per frame
    void Update()
    {
        key = PlayerCtrl.key; 
        KeyText.text = "찾은 일기 : " + key;
    }
}
