using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfFollowPlayer : MonoBehaviour
{
    public GameObject gameObjectToFollow;
    private Vector3 basePos;
    // Start is called before the first frame update
    void Start()
    {
        basePos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = basePos + new Vector3(gameObjectToFollow.transform.position.x, 0, 0) / 2;
    }
}
