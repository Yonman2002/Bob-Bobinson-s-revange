using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItems : MonoBehaviour
{
    public bool isOnItem;
    public Item item;
    public GameObject itemObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnItem && Input.GetButtonUp("Jump"))
        {
            Item temp = gameObject.GetComponent<HoldItem>().item;
            gameObject.GetComponent<HoldItem>().item = item;
            if (temp != null)
            {
                temp.gameObject.transform.parent = null;
                itemObject.GetComponent<Item>().damage = temp.damage;
            }
            isOnItem = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            isOnItem = true;
            item = collision.gameObject.GetComponent<Item>();
            itemObject = collision.gameObject;
        }        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            isOnItem = false;
        }        
    }
}
