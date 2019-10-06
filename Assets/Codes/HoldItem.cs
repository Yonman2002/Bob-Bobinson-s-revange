using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldItem : MonoBehaviour
{
    public Item item = null;
    public GameObject player;
    public float rotSpeed = 180;
    public AudioClip attackSound;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (item != null)
        {
            Transform topParent = player.transform;
            while (topParent.parent.parent != null)
            {
                topParent = topParent.parent;
            }
            item.transform.parent = topParent;
            item.transform.localPosition = new Vector3(0.2f, 0.06f, 0);
            if (!item.isAttacking)
            {
                item.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
        if (!this.GetComponent<PickItems>().isOnItem)
        {
            if (Input.GetButtonUp("Jump"))
            {
                if (item != null)
                {
                    item.isAttacking = true;
                    GameObject.FindObjectOfType<AudioSource>().PlayOneShot(attackSound);
                }                
            }
        }
        if (item != null && item.isAttacking)
        {
            item.gameObject.transform.localEulerAngles = new Vector3(0, 0, -count * rotSpeed);
            count += Time.deltaTime;
            if (count >= 1)
            {
                count = 0;
                item.isAttacking = false;
                item.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
    }
}
