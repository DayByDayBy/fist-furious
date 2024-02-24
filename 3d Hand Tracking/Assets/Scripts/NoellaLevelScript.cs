using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoellaLevelScript : MonoBehaviour
{
    public List <GameObject> myGameObjs = new List<GameObject>();
    Trigger trigger;


    public Material green, red;

    public float timer, timerLength;
    // Start is called before the first frame update
    void Start()
    {
        //SelectRandomObject();
        //print(myGameObjs[0].name);
    }

    //Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerLength){
            timer = 0;
            PaintAll();
            SelectRandomObject();
        }
    }

    void PaintAll(){
        Renderer ren;
        foreach (GameObject obj in myGameObjs){  
            ren = obj.GetComponentInChildren<Renderer>();
            ren.material = red;
            trigger = obj.GetComponent<Trigger>();
            trigger.shouldBeHit = false;      

        }
    }

    void SelectRandomObject(){
        int selectedObj = 0;
        selectedObj = Random.Range(0, 5);
        GameObject tempObj = myGameObjs[selectedObj];

        //print(tempObj);
        Renderer newRen =  tempObj.GetComponentInChildren<Renderer>();
        newRen.material = green;

        Trigger newTrigger = tempObj.GetComponent<Trigger>();
        newTrigger.shouldBeHit = true; 
    }

    
    
}
