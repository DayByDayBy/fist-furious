using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    GameObject fingertip;

    Collider fingertipColl;

    Renderer ren;

    public bool shouldBeHit = false;

    Material material;

    
    // Start is called before the first frame update
    void Start()
    {
        fingertipColl = fingertip.GetComponent<Collider>();
        ren = GetComponentInChildren<Renderer>();
        ren.material.color = Color.white;
        //Debug.Log(ren.gameObject.name + " is name");
    }

    // Update is called once per frame
    // void Update()
    // {
        

    void OnTriggerEnter(Collider other)
    {
        //print("DEBUG");
        if(other.gameObject.tag == "Index Tip")
        {
            print("INDEX COLLIDED WITH");
            if (shouldBeHit == true)
            {
                print("GOING TO MAIN MENU");
                SceneManager.LoadScene(0);
            }
        }

        
    }
    // private void OnTriggerStay(Collider other) {

    // }


}



