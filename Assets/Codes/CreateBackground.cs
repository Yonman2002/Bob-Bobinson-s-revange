using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject player;
    public GameObject clouds;
    public GameObject buildings;
    public GameObject otherBuildings;
    private bool happend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("buildings pos: " + buildings.transform.position.x);
        Debug.Log("otherbuildings pos: " + otherBuildings.transform.position.x);
        Debug.Log("player pos: " + player.transform.position.x);
        if ((Mathf.Abs(buildings.transform.position.x) - Mathf.Abs(player.transform.position.x) > 0) && (Mathf.Abs(buildings.transform.position.x) - Mathf.Abs(player.transform.position.x) < 20f))
        {
            Debug.Log("first if");
            if (player.transform.position.x >= 0)
            {
                Debug.Log("first if inside if");
                otherBuildings.transform.position = new Vector3(buildings.transform.position.x + 20f, otherBuildings.transform.position.y, otherBuildings.transform.position.z);
            }
            else
            {
                Debug.Log("first if inside else");
                otherBuildings.transform.position = new Vector3(buildings.transform.position.x - 20f, otherBuildings.transform.position.y, otherBuildings.transform.position.z);
            }
            happend = true;
            GameObject temp = buildings;
            buildings = otherBuildings;
            otherBuildings = temp;
        }

        if (!happend && Mathf.Abs(otherBuildings.transform.position.x) - Mathf.Abs(player.transform.position.x) < 20f)
        {
            Debug.Log("second if");
            if (player.transform.position.x >= 0)
            {
                Debug.Log("second if inside if");
                buildings.transform.position = new Vector3(otherBuildings.transform.position.x + 20f, buildings.transform.position.y, buildings.transform.position.z); 
            }
            else
            {
                Debug.Log("second if inside else");
                buildings.transform.position = new Vector3(otherBuildings.transform.position.x - 20f, buildings.transform.position.y, buildings.transform.position.z);
            }
            GameObject temp = buildings;
            buildings = otherBuildings;
            otherBuildings = temp;
        }
        happend = false;
    }
}
