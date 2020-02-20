using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour
{
     Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(this.gameObject.transform);
    if (this.gameObject.transform.childCount == 4)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            Debug.Log("Fff");
        }
    
    
    
    }

}
