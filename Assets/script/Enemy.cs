using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    public SpriteRenderer sr;

    public int maxHealth = 100;
    int currentHealth;

    public float attackRange = 0.5f;
    public int attackDelay = 2;
    float lastAttacked = -9999;
    public LayerMask playerLayers;

    //materials
    private Material matWhite;
    private Material matDefault;

    Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = sr.material;

        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Attack();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        sr.material = matWhite;
        KnockBack();
        if(currentHealth <= 0)
        {
            Die();
        } else
        {
            Invoke("ResetMaterial", .1f);
        }
    }

    private void KnockBack()
    {
        // Update position
        if(transform.position.x < player.position.x)
        {
            rigidbody.AddForce(transform.right * -300);
        } else
        {
            rigidbody.AddForce(transform.right * 300);
        }
        
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("IsDead",true);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<EnemyGhostAI>().enabled = false;
        this.enabled = false;
    }

    void Attack()
    {
        //Detect player
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(transform.position, attackRange, playerLayers);
        //Damage him
        foreach(Collider2D player in hitPlayer)
        {
                Debug.Log("masuk");
            if (Time.time > lastAttacked + attackDelay)
            {
                player.GetComponent<Hearth>().TakeDamage();
                lastAttacked = Time.time;
            }
        }

        
    }
}
