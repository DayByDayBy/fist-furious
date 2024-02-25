using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RossColliderScript : MonoBehaviour
{   
    public Transform scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = GameObject.Find("AllSceneObjects").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {   
            //SceneManager.LoadScene(5);
            scene.position = new Vector3(4.3f, 0, 4.3f);
            print("Ball hole");
        }
    }
}
