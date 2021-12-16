using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private Animator animation;

    public void Awake()
    {
        animation = GetComponent<Animator>();
    }

    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i=0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            } 
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void TakeDamage(int amount)
    {
        health -= 1;
        animation.SetBool("hurt", true);

        if(health <=0)
        {
            animation.SetBool("dead", true);
            // Show Gameover screen
        }
    }
}
