using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironment : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed =1f;
    public float yspeed =0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 4) //move right
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -4) //move left
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z <6) //move up z
        {
            transform.position += new Vector3(0f, 0f,speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z > -2) //move down z
        {
            transform.position -= new Vector3(0f, 0f,speed * Time.deltaTime);
        }  
        if (Input.GetKey(KeyCode.Space) && transform.position.y < 0) //move up y
        {
            transform.position += new Vector3(0f, yspeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.Space)==false && transform.position.y > -2)
        {
            transform.position -= new Vector3(0f, yspeed * Time.deltaTime, 0f);
        }
    }
}
