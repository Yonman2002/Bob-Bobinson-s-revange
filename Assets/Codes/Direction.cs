using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public GameObject gameObject;
    public Rigidbody2D rigidbody;
    public AdvancedAnimation animation;
    public AdvancedAnimation idle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.x == 0)
        {
            animation.Active = false;
            idle.StartAnimations();
        }
        else if (rigidbody.velocity.x > 0)
        {
            idle.Active = false;
            animation.StartAnimations();
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0.5f);
            gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            animation.StartAnimations();
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -0.5f);
            gameObject.transform.localEulerAngles = new Vector3(0, 180, 0);
        }

    }
}
