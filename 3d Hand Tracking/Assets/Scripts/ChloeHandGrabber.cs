using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChloeHandGrabber : MonoBehaviour
{
    
    public GestureScript gestureScript;
    //public GameObject indexPoint;
    public Transform indexPoint;
    public Transform environment;
    // Start is called before the first frame update
    GameObject[] gameObjects;
    GameObject closestObj;
    Rigidbody rigidObj;

    float currDist, maxDist;

    public float threshold;
    public bool objectGrabbed = false;

    public GameObject boxPrefab;
    public int numOfBoxes;
    public GameObject duckPrefab;

    public float timer, timerLength;
  
    public Transform spawnPos;
    bool duckSpawned = false;

    public List<GameObject> allCraneObjects;
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Crane Object");
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        
        if (timer > timerLength){
            if (numOfBoxes > 0){
                if (duckSpawned == false){
                    GameObject myDuck = Instantiate(duckPrefab, spawnPos, worldPositionStays:false);
                    duckSpawned = true;
                    allCraneObjects.Add(myDuck);
                }
                Instantiate(boxPrefab, spawnPos, worldPositionStays:false);
                timer = 0f;
                numOfBoxes--;
                if ( numOfBoxes==0){
                    gameObjects = GameObject.FindGameObjectsWithTag("Crane Object");
                    foreach (GameObject go in gameObjects){
                        allCraneObjects.Add(go);
                    }

                }
            }
        }
        


        if (gestureScript.indexStraight == false 
        && gestureScript.middleStraight == false
        && gestureScript.ringStraight == false
        && gestureScript.littleStraight == false
        && gestureScript.thumbStraight == false)
        {
         //   Debug.Log("Hand is in gripping pose");
            //reference to index point
            maxDist = Mathf.Infinity;
            foreach(GameObject gO in allCraneObjects){
                
                Vector3 diff = gO.transform.position - indexPoint.position;
                currDist = diff.sqrMagnitude;
                //Debug.Log(currDist);
                if(currDist < maxDist){
                    closestObj = gO;
                    maxDist = currDist;
                    //Debug.Log(maxDist);
                    if (maxDist < threshold)
                    {
                        Debug.Log("Object Detected");
                        closestObj.transform.SetParent(indexPoint);
                        //closestObj.transform.localPosition = new Vector3(0,0,0); //can use this or not depending on visuals we want 
                        rigidObj = closestObj.GetComponent<Rigidbody>();
                        rigidObj.isKinematic = true;
                        objectGrabbed = true;
                  }
                }
            }
            
        }
        if (gestureScript.indexStraight == true
        && gestureScript.middleStraight == true
        && gestureScript.ringStraight == true
        && gestureScript.littleStraight == true
        && gestureScript.thumbStraight == true
        && objectGrabbed == true)
        {
            rigidObj.isKinematic = false;
            closestObj.transform.SetParent(environment);
           // closestObj.GetComponent<Rigidbody>();

        }
 /*       if (ges tureScript.indexStraight == true
        && gestureScript.middleStraight == true
        && gestureScript.ringStraight == true
        && gestureScript.littleStraight == true
        && gestureScript.thumbStraight == true
        && objectGrabbed =true) //
        {
            Debug.Log("HERE");
            closestObj.AddComponent<Rigidbody>();
            closestObj.transform.parent = null;

        }
*/
    }
}
