using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cube : MonoBehaviour
{
  
    public Collider collider;
    public GameObject swordP,panelP;
    

    Rigidbody rb;
    Animator animator;
    public GameObject sword;
    bool panelPB=false;
    // Start is called before the first frame update
    void Start()
    {
        panelP.SetActive(false);
       rb = GetComponent<Rigidbody>();
       animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (sword.GetComponent<sword>().dead >= 50 && panelPB==false)
        {
            animator.SetInteger("animEn",1);
            
            collider.enabled=false;

            panelP.SetActive(true);
        }

        if(Input.GetKey(KeyCode.F))
        {
            panelP.SetActive(false);
            panelPB = true;
        }

        

    }
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetInteger("animEn", 2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetInteger("animEn", 0);
        }
    }

}
