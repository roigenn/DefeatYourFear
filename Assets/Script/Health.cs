using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float dogh, dogmaxh, dogdecreaseh;
    public float water, watermaxh, waterdecreaseh;
    public GameObject dog;
    Animator anim;

    public GameObject DogBar, WaterBar;
    void Start()
    {
       
        dogh = dogmaxh;
        water = watermaxh;
        anim = dog.GetComponent<Animator>();
        
    }

    void Update()
    {
        DogBar.transform.localScale = new Vector2(dogh / dogmaxh, 1);
        WaterBar.transform.localScale = new Vector2(water / watermaxh, 1);

        if (anim.GetBool("isDog") == true)
        {
            water += waterdecreaseh * Time.deltaTime;
            dogh += dogdecreaseh * Time.deltaTime;
        }
        else
        {
            water -= waterdecreaseh * Time.deltaTime;

            if (water <= 50)
            {
                dogh -= dogdecreaseh * Time.deltaTime;
            }
        }

        
        
        //Dog
        if (dogh > dogmaxh)
        {
            dogh = dogmaxh;
        }
        if (dogh <= 0)
        {
            dogh = 0;
        }
        //Water
        if (water <= 0)
        {
            water = 0;
        }
        if (water > watermaxh)
        {
            water = watermaxh;
        }
       

        
    }

    
}
