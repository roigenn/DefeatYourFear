using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAcro : MonoBehaviour
{

    public GameObject cameraOne, cameraTwo;
    private bool cameraBool = true;
   

    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && cameraOne.activeSelf)
        {
            cameraTwo.SetActive(true);
            cameraOne.SetActive(false);

        }
        else if (Input.GetKeyUp(KeyCode.E) && cameraTwo.activeSelf)
        {

            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
        }
       
    }

}
