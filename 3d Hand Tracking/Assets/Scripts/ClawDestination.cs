using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClawDestination : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void OnTriggerEnter(Collider other)
    {
        //print("DEBUG");
        if(other.gameObject.tag == "Crane Object")
        {

            print("NOT THE DUCK");
            Destroy(other.gameObject);
            //SceneManager.LoadScene(0);
        
        }
        if(other.gameObject.tag == "Duck")
        {
            SceneManager.LoadScene(0);
        }

        
    }
}