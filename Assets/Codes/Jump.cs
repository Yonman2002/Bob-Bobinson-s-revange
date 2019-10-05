using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed;
    public CheckJumpable jumpCollider;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical") && jumpCollider.isAbleToJump)
        {
            ActivateJump();
        }
    }

    public void ActivateJump()
    {
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpSpeed);
    }
}
