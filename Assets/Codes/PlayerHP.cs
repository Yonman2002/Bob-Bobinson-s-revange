using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int hp;
    public Image healthBar;
    public string scene;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (hp <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (count >= 2f)
            {
                count = 0;
                hp--;
                healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(hp * 20, 14);
            }
        }
    }
}
