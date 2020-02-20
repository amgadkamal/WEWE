using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggableball : MonoBehaviour
{

    private Rigidbody2D rb;
    Animator animator;
    int state;
    int initialState;
    public static int control = 0;

    // Start is called before the first frame update

    private bool mousee;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        state = animator.GetInteger("CurrentState");

    }


    IEnumerator ColorShift()
    {
        yield return new WaitForSecondsRealtime(1);
        state = ++state % 3;
        animator.SetInteger("CurrentState", state);
        StopCoroutine("ColorShift");
        StartCoroutine("ColorShift");

    }

   

    public void OnMouseDown()
    {
        mousee = true;

    }

    public void OnMouseUp()
    {
        mousee = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (mousee)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(this.gameObject.transform);
        if (this.gameObject.transform.childCount == 8)
        {

            mousee = false;
           rb.freezaRotation = true;
            x = 1;


        }

    }
    public void animation()
    {
        
        StartCoroutine("ColorShift");
        
    }
    public void SetState(int value)
    {
        StopCoroutine("ColorShift");
        initialState = value;
        state = value;
        animator.SetInteger("CurrentState", state);
    }

    public void ResetAndPause()
    {
        StopCoroutine("ColorShift");
        state = 0;
        animator.SetInteger("CurrentState", state);
    }


}
    

