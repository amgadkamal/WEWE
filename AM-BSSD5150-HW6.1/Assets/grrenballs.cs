using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grrenballs : MonoBehaviour
{
    private draggableball[] circles;
    Animator animator;
    int state;
    
    // Start is called before the first frame update
    void Start()
    
    {
        animator = GetComponent<Animator>();
        state = animator.GetInteger("CurrentState");
        circles = FindObjectsOfType<draggableball>();

    
    }
    

    // Update is called once per frame
    void Update()

    {
        
        animation();    
        
    }
}
