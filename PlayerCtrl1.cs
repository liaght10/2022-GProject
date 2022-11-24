using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtrl1 : MonoBehaviour
{
    private Transform tr;

    private Animation anim;
    
    public float moveSpeed = 1.0f;

    public float turnSpeed = 80.0f;


    public GameObject last; //chart

    public GameObject window;

    public Text closed;

   public int truth = 0;
    public AudioClip doorOpen;
    AudioSource audioSource;

    IEnumerator Start()
    {
 
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();

        turnSpeed = 0.0f;
        yield return new WaitForSeconds(0.3f);
        turnSpeed = 80.0f;                                                                                                                                                                                                                                                          

        closed.enabled = false;

        last.SetActive(false);
        window.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");
        
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        
        tr.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "chart")
        {
            last.SetActive(true);
            truth++;
        }

        if (other.gameObject.tag == "door_")
        {

            if (truth < 1)
            {
                closed.enabled = true;
            }

            else if (truth >= 1)
            {
                audioSource.Play();
                SceneManager.LoadScene("Main");

            }
        }
        
    }

    void OnCollisionExit(Collision other3)
    {
        if (other3.gameObject.tag == "chart")
        {
            last.SetActive(false);
        }

        if (other3.gameObject.tag == "door_")
        {
            closed.enabled = false;

        }
        if (other3.gameObject.tag == "window")
        {
            window.SetActive(false);

        }
    }

}