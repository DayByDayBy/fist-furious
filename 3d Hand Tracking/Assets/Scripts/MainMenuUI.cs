using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{

    public GestureScript gestureScript;

    [SerializeField]
    GameObject mainDisplay;
    TextMeshProUGUI text; 

    int howManyFingers = 0;

    float timer = 0.0f;
    [SerializeField]
    public float timerLength; 

    // Start is called before the first frame update
    void Start()
    {
        mainDisplay.SetActive(false);
        text = mainDisplay.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        howManyFingers = 0;

        if (gestureScript.thumbStraight) howManyFingers++;
        if (gestureScript.indexStraight) howManyFingers++;
        if (gestureScript.middleStraight) howManyFingers++;
        if (gestureScript.ringStraight) howManyFingers++;
        if (gestureScript.littleStraight) howManyFingers++;

        switch (howManyFingers)
        {
            case 0:
                timer = 0;
                mainDisplay.SetActive(false);
                break;
            case 1:
                FingerNavigate(1);
                //
                break;
            case 2:
                FingerNavigate(2);
                //
                break;
            case 3:
                FingerNavigate(3);
                //
                break;
            case 4:
                FingerNavigate(4);
                //
                break;
            case 5:
                FingerNavigate(5);
                //
                break;

        }
        print(howManyFingers);

        
        //timer = 0.0f;

    }

    void FingerNavigate(int fingers)
    {
        timer += Time.fixedDeltaTime;
        mainDisplay.SetActive(true);
        text.text = ("Navigating to Level " + fingers.ToString());

        //print(timer);

        if (timer > timerLength)
        {
            print("LEVEL "+ fingers.ToString() + " NAV SUCCESS");
            //SceneManager.LoadScene(fingers);
        }
    }
    
}
