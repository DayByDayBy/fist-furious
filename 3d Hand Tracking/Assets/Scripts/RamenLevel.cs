using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RamenLevel : MonoBehaviour
{
    public GestureScript gestureScript;
    public TextMeshProUGUI baseObj, textObj;

    [SerializeField]
    GameObject[] walls;
    



    //on attack, get hand pose and win or lose
    //Rock == default
    //Scissors == if index and middle straight
    //Paper == above, plus ring and maybe little?

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //first timer to spawn object

            //int whatToSpawn = Random.Range(0, 3);
            //print(whatToSpawn);
            //Instantiate(walls[whatToSpawn], new Vector3(0, 0, 0), Quaternion.identity);


            //second timer for how long until it attacks, display on the text object
                //check if pose correct
                    //success, loop
                    //fail, load game over scene?



    }


}
