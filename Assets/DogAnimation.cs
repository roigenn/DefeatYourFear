using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimation : MonoBehaviour
{
    Animator anim;
    public GameObject dog;
    bool icerde = false;

    private void Start()
    {
        anim = dog.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && icerde == true)
        {
            anim.SetBool("isDog", true);
        }
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        icerde = true;
        anim.SetBool("isCome", false);
    }

    private void OnTriggerExit(Collider other)
    {
        icerde = false;
        anim.SetBool("isDog", false);
        anim.SetBool("isCome", true);

    }


}
