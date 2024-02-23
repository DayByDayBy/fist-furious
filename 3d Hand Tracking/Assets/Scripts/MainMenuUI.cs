using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField]
    GameObject mainDisplay;

    int howManyFingers = 0;

    float timer = 0.0f;
    [SerializeField]
    public float timerLength; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        howManyFingers = 0;

        if (GestureScript.thumbStraight) howManyFingers++;
        if (GestureScript.indexStraight) howManyFingers++;
        if (GestureScript.middleStraight) howManyFingers++;
        if (GestureScript.ringStraight) howManyFingers++;
        if (GestureScript.littleStraight) howManyFingers++;

        switch (howManyFingers)
        {
            case 1:
                OneFinger();
                break;
            case 2:
                TwoFinger();
                break;
            case 3:
                ThreeFinger();
                break;
            case 4:
                FourFinger();
                break;
            case 5:
                FiveFinger();
                break;

        }

        mainDisplay.SetActive(false);
        timer = 0.0f;

    }

    void OneFinger()
    {
        while (howManyFingers == 1)
        {
            timer += Time.fixedDeltaTime;
            mainDisplay.SetActive(true);
            if (timer > timerLength)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    void TwoFinger()
    {
        while (howManyFingers == 2)
        {
            
        }
        
    }

    void ThreeFinger()
    {
        while (howManyFingers == 3)
        {

        }

    }

    void FourFinger()
    {
        while (howManyFingers == 4)
        {

        }

    }

    void FiveFinger()
    {
        while (howManyFingers == 5)
        {

        }

    }



}
