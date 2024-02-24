using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBoxSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject boxPrefab;

    [SerializeField]
    float timerLength;
    float timer;
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
            GameObject newBox = Instantiate(boxPrefab, new Vector3(0, 5, 0), Quaternion.identity);
            Destroy(newBox, 5);
            timer = 0;
        }
    }
}
