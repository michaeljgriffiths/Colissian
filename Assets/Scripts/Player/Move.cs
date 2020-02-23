using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int force = 7;
    private int m_InputX;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        m_InputX = Mathf.FloorToInt(Input.GetAxisRaw("Horizontal"));

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += Movement * force * Time.deltaTime;

        // Flip our sprite if needed
        if (m_InputX < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (m_InputX > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            //animator.SetTrigger("Run");
            animator.SetBool("Run", true);
        }
        if (Input.anyKey == false)
        {
            //animator.SetTrigger("Idle");
            animator.SetBool("Run", false);
        }
    }


}
