using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float dogh, dogmaxh, dogdecreaseh;
    public float water, watermaxh, waterdecreaseh;
    public GameObject dog;
    Animator anim;
    public bool icerdema;
    public GameObject starting;

    public GameObject DogBar, WaterBar;
    void Start()
    {
        icerdema = false;
        dogh = dogmaxh;
        water = watermaxh;
        anim = dog.GetComponent<Animator>();
        
    }

    void Update()
    {
        DogBar.transform.localScale = new Vector2(dogh / dogmaxh, 1);
        WaterBar.transform.localScale = new Vector2(water / watermaxh, 1);

        if (icerdema == false && starting.activeSelf)
        {
            water -= waterdecreaseh * Time.deltaTime;

            if (water <= 50)
            {
                dogh -= dogdecreaseh * Time.deltaTime;
            }
        }

        if (icerdema == true)
        {
            water += waterdecreaseh * Time.deltaTime;
            dogh += dogdecreaseh * Time.deltaTime;
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            icerdema = true;
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            icerdema = false;
        }
    }


}
