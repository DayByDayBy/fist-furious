using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RossScript : MonoBehaviour
{
    public GestureScript gestureScript;
    private int frameCount;
    public Transform scene;

    public Transform dirFrom;
    public Transform dirTo;

    public float speed;
    public float threshold;

    

    // Start is called before the first frame update
    void Start()
    {
        frameCount = 0;
        scene.transform.position = new Vector3(4.5f, 0, 4.5f);
    }

    // Update is called once per frame
    void Update()
    { 
        frameCount++;
        if (frameCount <= 10)
        {
            return;
        }

        //ContinuallyMove(shouldMove);
        
            if (
             gestureScript.indexStraight == true
            && gestureScript.middleStraight == false
            && gestureScript.ringStraight == false
            && gestureScript.littleStraight == false
            && gestureScript.thumbStraight == false)
        {
            // Calculate direction from dirFrom to dirTo
            Vector3 direction = new Vector3(dirTo.position.x - dirFrom.position.x, 0f, dirTo.position.z - dirFrom.position.z);

            // Check if magnitude of direction vector exceeds threshold
            if (direction.magnitude > threshold)
            {
                //shouldMove = true;
                // Translate camera position based on direction vector
                scene.transform.position -= direction.normalized * Time.deltaTime * speed;
                //if scene position is less than -10 or greater than 10, reset position to 0
                if (scene.transform.position.x < -5)
                {
                    scene.transform.position = new Vector3(-5, scene.transform.position.y, scene.transform.position.z);
                }
                if (scene.transform.position.x > 5)
                {
                    scene.transform.position = new Vector3(5, scene.transform.position.y, scene.transform.position.z);
                }
                if (scene.transform.position.z < -5)
                {
                    scene.transform.position = new Vector3(scene.transform.position.x, scene.transform.position.y, -5);
                }
                if (scene.transform.position.z > 5)
                {
                    scene.transform.position = new Vector3(scene.transform.position.x, scene.transform.position.y, 5);
                }
                
            }
        }
        

    }

    /*void ContinuallyMove(bool param){
        scene.transform.position += direction.normalized * Time.deltaTime * speed;
    }*/
}
