using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int force = 7;
    private int m_InputX;

    public Animator animator;
    private SpriteRenderer spriteRenderer;

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

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Trigger run animation");
            animator.SetTrigger("Run");
        }
        else
        {
            Debug.Log("Trigger idle animation");
            animator.SetTrigger("Idle");
        }
    }


}
