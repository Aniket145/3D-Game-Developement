using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camChange : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.X))
        {
          cam1.SetActive(true);
            cam2.SetActive(false);  
        }
    }
}
