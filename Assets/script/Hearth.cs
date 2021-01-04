using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hearth : MonoBehaviour
{
    public static int health=5;
    public int numOfHearth;
    public bool hasDied;
    public static Hearth instance;

    public Image[] hearths;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Animator animator;

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        hasDied=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(health > numOfHearth)
        {
            health = numOfHearth;
        }

        for (int i = 0; i < hearths.Length; i++)
        {
            if (i < health)
            {
                hearths[i].sprite = fullHeart;
            } else
            {
                hearths[i].sprite = emptyHeart;
            }

            if (i < numOfHearth)
            {
                hearths[i].enabled = true;
            } else
            {
                hearths[i].enabled = false;
            }
        }
        
        if(gameObject.transform.position.y < -7){
            health = 0;
        }
        
        if(health == 0)
        {
            Die();
        }


    }

    private void Die()
    {
        GetComponent<Collider2D>().enabled = false;
        //GetComponent<PlayerController>().enabled = false;
        //GetComponent<PlayerComboAttack>().enabled = false;
        this.enabled = false;
        health = 5;
        SceneManager.LoadScene("GameOver");
        //StartCoroutine("Respawn");
    }

    public void TakeDamage()
    {
        if(health>0){
        health--;
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Enemy")
        print("s");
    }

    IEnumerator Respawn(){
        health = 5;
        SceneManager.LoadScene("GameOver");
        yield return null;
    }
}
