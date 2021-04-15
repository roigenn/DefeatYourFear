using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float dogh, dogmaxh, dogdecreaseh;
    public float water, watermaxh, waterdecreaseh;

    public GameObject HealthBar, DogBar, WaterBar;
    void Start()
    {
       
        dogh = dogmaxh;
        water = watermaxh;
        
    }

    void Update()
    {
        DogBar.transform.localScale = new Vector2(dogh / dogmaxh, 1);
        WaterBar.transform.localScale = new Vector2(water / watermaxh, 1);

        
        
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
        if (water > 0)
        {
            water -= waterdecreaseh * Time.deltaTime;
        }

        //water and dog
        if(water<=0)
        {
            dogh -= dogdecreaseh * 2 * Time.deltaTime;
        }
        if(water <= 50)
        {
            dogh -= dogdecreaseh  * Time.deltaTime;
        }
        
    }
}
