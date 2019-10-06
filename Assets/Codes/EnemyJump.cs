using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float jumpSpeed;
    public Rigidbody2D rigidbody;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= 3.5f)
        {
            int rnd = Random.Range(0, 2);
            if (rnd == 0)
            {
                Jump();
            }
            count = 0;
        }
    }

    private void Jump()
    {
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpSpeed);
    }
}
