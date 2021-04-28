using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject cameraOne, cameraTwo;
    private bool cameraBool = true;
   

    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T) && cameraOne.active == true)
        {
            cameraTwo.SetActive(true);
            cameraOne.SetActive(false);

        }
        else if (Input.GetKeyUp(KeyCode.T) && cameraTwo.active == true)
        {

            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
        }
       
    }

}
