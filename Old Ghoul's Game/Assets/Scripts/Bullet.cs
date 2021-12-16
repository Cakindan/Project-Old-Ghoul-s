using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 100;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        TheEnemy enemy = hitInfo.GetComponent<TheEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
