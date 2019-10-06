using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int hp;
    public Image healthBar;
    public AudioClip damagedSound;
    public string scene;
    private float count = 0;
    private float enemyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        enemyCount += Time.deltaTime;
        if (hp <= 0 && this.tag == "Player")
        {
            SceneManager.LoadScene(scene);
        }
        if (hp <= 0 && this.tag == "Boss")
        {
            SceneManager.LoadScene("Win Screen");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.tag == "Boss" && collision.gameObject.GetComponent<Item>() != null)
        {
            if (enemyCount >= 1f)
            {
                enemyCount = 0;
                hp -= collision.gameObject.GetComponent<Item>().damage;
            }
        }
        if (gameObject.tag == "Player" && (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss"))
        {
            if (count >= 2f)
            {
                count = 0;
                hp--;
                healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(hp * 20, 14);
                GameObject.FindObjectOfType<AudioSource>().PlayOneShot(damagedSound);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.tag == "Boss" && collision.gameObject.GetComponent<Item>() != null)
        {
            if (enemyCount >= 1f)
            {
                enemyCount = 0;
                hp -= collision.gameObject.GetComponent<Item>().damage;
            }
        }
    }
}
