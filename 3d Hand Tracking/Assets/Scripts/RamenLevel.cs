using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RamenLevel : MonoBehaviour
{
    public GestureScript gestureScript;
    public TextMeshProUGUI baseObj, textObj;

    [SerializeField]
    GameObject[] walls;
    GameObject currentWall = null;
    [SerializeField]
    Transform spawnPos;

    float timer1 = 0.0f;
    float timer2 = 0.0f;

    [SerializeField]
    float timer1Length;
    [SerializeField]
    float timer2Length;

    bool wallActive = false;

    int whatToSpawn; // 0 spawns rock, 1 scissors, 2 paper

    //on attack, get hand pose and win or lose
    //Rock == default
    //Scissors == if index and middle straight
    //Paper == above, plus ring and maybe little?

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        int handPose = GetHandPose();
        SpawnWall();
        WallAttack(handPose);

    }

    void SpawnWall()
    {
        

        timer1 += Time.fixedDeltaTime;
        if (!wallActive && timer1 > timer1Length)
        {
            wallActive = true;
            whatToSpawn = Random.Range(0, 3);

            print(whatToSpawn);
            currentWall = Instantiate(walls[whatToSpawn], new Vector3(0, 0, 0), Quaternion.identity);            

        }
    }

    int GetHandPose()
    {
        
        if (gestureScript.indexStraight && gestureScript.middleStraight)
        {
            if (gestureScript.ringStraight && gestureScript.littleStraight)
            {
                return 2; // paper
            }
            return 1; // scissors
        } 
        
        //ignoring the thumb
        return 0; // rock

    }

    void WallAttack(int pose)
    {
        if (wallActive)
        {
            timer2 += Time.fixedDeltaTime;
            if (timer2 > timer2Length)
            {
                //second timer for how long until it attacks, display on the text object
                if (pose == whatToSpawn || Input.GetKey(KeyCode.A))  
                {
                    timer1 = 0;
                    timer2 = 0;
                    Destroy(currentWall);
                    wallActive = false;
                    //success, reset timers and loop
                    print("SUCCESS");
                }
                else
                {
                    SceneManager.LoadScene(0);//else fail, load main scene
                }
                


                    
            }

            /*if (pose == whatToSpawn) { }
            //apply green? particle effect here if you have correct pose, red otherwise*/

        }
    }


}
