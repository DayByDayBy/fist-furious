using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RossColliderWin : MonoBehaviour
{   
    //public Transform scene;
    // Start is called before the first frame update
    void Start()
    {
        //scene = GameObject.Find("AllSceneObjects").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            print("Ball hole");
            SceneManager.LoadScene(0);
            
            
        }
    }
}