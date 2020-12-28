using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    int initialLife;

    
    private void Start()
    {
        life = hearts.Length;
        initialLife = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    public void TakeDamage(int d)
    {
        life -= d;
        hearts[life].GetComponent<Image>().enabled = false;
    }

    public void GetHealth(int h)
    {
        if (life < initialLife)
        {
            life += h;
            hearts[life - 1].GetComponent<Image>().enabled = true;
        }
        else if (life >= initialLife) Console.WriteLine("Full HP");
        
    }
}
