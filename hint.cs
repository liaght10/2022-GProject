using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint : MonoBehaviour
{
    static public bool touch = false;
    static public bool pill = false;
    static public bool door = false;

    private AudioSource buttonAudio;
    public AudioClip buttonSound;
    public GameObject hintt;
    public Text text;
    public Text Doortext;

    // Start is called before the first frame update
    void Start()
    {
        Doortext.enabled = false;
        this.buttonAudio = this.gameObject.AddComponent<AudioSource>();
        this.buttonAudio.clip = this.buttonSound;
        this.buttonAudio.loop = false;
        hintt.SetActive(false);
        text.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (touch == true)
        {
            hintt.SetActive(true);
        }
        else if (touch == false)
        {
            hintt.SetActive(false);
        }

        if (pill == true)
        {
            text.enabled = true;
        }
     else if (pill == false)
        {
            text.enabled = false;
        }

        if (door == true)
        {
            Doortext.enabled = true;
        }
       else if (door == false)
        {
            Doortext.enabled = false;
        }



    }

}
