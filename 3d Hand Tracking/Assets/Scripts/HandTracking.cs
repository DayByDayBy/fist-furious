using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;

    public float xOffset;
    public float yOffset;    

    void Start()
    {
        
    }
    
    void Update()
    {
        string data = udpReceive.data;
        
        
        try //errors at the start when data is null
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1);
            //print(data);
            string[] points = data.Split(',');
            //print(points[0]);

            for (int i = 0; i < 21; i++)
            {
                float x = xOffset - float.Parse(points[i * 3]) / 100;
                float y = (float.Parse(points[i * 3 + 1]) / 100) - yOffset;
                float z = float.Parse(points[i * 3 + 2]) / 100;

                handPoints[i].transform.localPosition = new Vector3(x, y, z);
            }

        }
        catch(Exception e)
        {
            print(e.ToString());
        }

        


    }
}
