using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
  
    public Collider collider;
    Rigidbody rb;
    Animator animator;
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (sword.GetComponent<sword>().dead >= 50)
        {
            animator.SetInteger("animEn",1);
            
            collider.enabled=false;
        }
        

    }
}
