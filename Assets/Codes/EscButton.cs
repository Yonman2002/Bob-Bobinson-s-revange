using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscButton : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Cancel"))
        {
            EnableDisable();
        }
    }

    public void EnableDisable()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            panel.SetActive(false);
        }
    }
}
