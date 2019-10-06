using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float speed;
    public float range;
    public GameObject target;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.transform.position, this.transform.position) <= range)
        {
            WalkTowardsTarget();
        }
    }

    public void WalkTowardsTarget()
    {
        if (target.transform.position.x < this.transform.position.x)
        {
            rigidbody.velocity = new Vector2(-1 * speed, rigidbody.velocity.y);
        }
        else
        {
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
        }
    }
}
