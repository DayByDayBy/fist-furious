using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JamesLevelScript : MonoBehaviour
{
    public float timer;
    public float timerLength;
    public static bool wasAKeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerLength)
        {
            print("Loading Main Menu");
            SceneManager.LoadScene(0);
        }
        if (wasAKeyPressed)
        {
            wasAKeyPressed = false;
            timer = 0f;
        }

    }
}
