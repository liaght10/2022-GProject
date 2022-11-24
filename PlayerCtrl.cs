using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCtrl : MonoBehaviour
{
    private Transform tr;
  
    private Animation anim;

  
    public float moveSpeed = 17.0f;


    public float turnSpeed = 80.0f;

    static public int key = 0;

    public bool JumpCheck = false;

    public float jumpPower;

    Rigidbody rigidbody;

    public int pill = 0;

    public Text pillText;

    public Text amountText;

    public Text needText;

    public Text DeadText;

    public Text wakeText;

    public Text notEnough;


    public GameObject reboot;

    public GameObject book2;
    public GameObject book3;
    public GameObject book4;
    public GameObject book5;

    public GameObject night;

    bool sandtouch = false;

    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();

        pillText.enabled = false;
        needText.enabled = false;
        notEnough.enabled = false;
        DeadText.enabled = false;
        wakeText.enabled = false;
        amountText = GetComponent<Text>();
        reboot.SetActive(false);


        book2.SetActive(false);
        book3.SetActive(false);
        book4.SetActive(false);
        book5.SetActive(false);

        amountText.text = " : " + pill;

 

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
        if (other.gameObject.tag == "book2")
        {
            book2.SetActive(true);
            key++;
        }

        if (other.gameObject.tag == "book3")
        {
            book3.SetActive(true);
            key++;
        }
        if (other.gameObject.tag == "book4")
        {
            key++;
            book4.SetActive(true);         
        }
        if (other.gameObject.tag == "book5")
        {
            book5.SetActive(true);
            key++;

        }
        if (other.gameObject.tag == "exit")
        {
            if (key < 5)
            { notEnough.enabled = true; }

            else if (key >= 5)
            { SceneManager.LoadScene("Truth"); }
        }

    }


    void OnCollisionExit(Collision other3)
    {
        if (other3.gameObject.tag == "book2")
        {
            book2.SetActive(false);
        }
        if (other3.gameObject.tag == "book3")
        {
            book3.SetActive(false);
        }
        if (other3.gameObject.tag == "book4")
        {
            book4.SetActive(false);
        }
        if (other3.gameObject.tag == "book5")
        {
            book5.SetActive(false);
        }
        if (other3.gameObject.tag == "exit")
        {
            notEnough.enabled = false;
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "pill")
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Destroy(other.gameObject);
                pillText.enabled = false;

            }
        }
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "diary")
        {
            hint.touch = true;
            key++;
        }

        if (other.gameObject.tag == "warning")
        {
            if (pill >= 1)
            {
                night.SetActive(false);
            }
            else if (pill<=0)
            { needText.enabled = true;}
        }

        if (other.gameObject.tag == "pill")
        {
            pillText.enabled = true;
            pill++;
        }

        if (other.gameObject.tag == "blood")
        {
            MonsterCtrl.touched = true;
        }

        if (other.gameObject.tag == "sand")
        {
            SceneManager.LoadScene("start");
        }
        if (other.gameObject.tag == "sand2")
        {
            SceneManager.LoadScene("start");
        }
        if (other.gameObject.tag == "sand3")
        {
            SceneManager.LoadScene("start");
        }
        if (other.gameObject.tag == "sand4")
        {
            SceneManager.LoadScene("start");
        }

    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.tag == "diary")
        {
            hint.touch = false; 


        }

        if (Other.gameObject.tag == "door")
        {
            hint.door = false;
            Debug.Log("dd222");
        }

        if (Other.gameObject.tag == "warning")
        {
            needText.enabled = false;
        }
        if (Other.gameObject.tag == "pill")
        {
            pillText.enabled = false;
           
        }
    }


}