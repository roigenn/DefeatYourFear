using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimation : MonoBehaviour
{
    Animator anim, anim2;
    public GameObject dog;
    public GameObject karakter;
    bool icerde = false;

    public GameObject cameraOne, cameraTwo;
    private bool cameraBool = true;


    private void Start()
    {
        anim = dog.GetComponent<Animator>();
        anim2 = karakter.GetComponent<Animator>();
        
        
    }


    public void FixedUpdate()
    {
        
        if(icerde == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && cameraOne.activeSelf)
            {
                cameraTwo.SetActive(true);
                cameraOne.SetActive(false);
                anim2.SetBool("dogLove", true);

            }
            else if (Input.GetKeyDown(KeyCode.E) && cameraTwo.activeSelf)
            {
                cameraOne.SetActive(true);
                cameraTwo.SetActive(false);
                

            }
        }
 
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            icerde = true;
            anim.SetBool("isDog", true);
            anim.SetBool("isLow", true);
            anim.SetBool("isCome", false);
        }
        
        
    }

    private void OnTriggerExit(Collider other)
    {
            icerde = false;
            anim.SetBool("isCome", true);
        anim2.SetBool("dogLove", false);
      

    }


}
