using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemy : MonoBehaviour
{
    public int health = 90;
    public GameObject deathEffect;
    public GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            var healthComponent = collision.GetComponent<Health>();
            if(healthComponent != null)
            {
                healthComponent.TakeDamage(1);
            }
            else
            {
                Destroy(player.gameObject);
            }
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);     
    }
}
