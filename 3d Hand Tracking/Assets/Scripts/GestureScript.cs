using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureScript : MonoBehaviour
{    
    //mimnimum tolerance angles for each finger
    float thumbThresh = 20.0f;
    float indexThresh = 10.0f;
    float middleThresh = 10.0f;
    float ringThresh = 10.0f;
    float littleThresh = 15.0f;

    [SerializeField]
    Transform little1, little2, little3, little4;
    [SerializeField]
    Transform ring1, ring2, ring3, ring4;
    [SerializeField]
    Transform middle1, middle2, middle3, middle4;
    [SerializeField]
    Transform index1, index2, index3, index4;
    [SerializeField]
    Transform thumb1, thumb2, thumb3;

    [SerializeField]
    public static bool thumbStraight, indexStraight, middleStraight, ringStraight, littleStraight;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 thumbLower = thumb2.position - thumb1.position;
        Vector3 thumbUpper = thumb3.position - thumb2.position;
        float angle = Vector3.Angle(thumbLower, thumbUpper);
        if (angle < thumbThresh)
        {
            thumbStraight = true;
        }
        else thumbStraight = false;

        Vector3 indexLower = index2.position - index1.position;
        Vector3 indexUpper = index4.position - index3.position;
        angle = Vector3.Angle(indexUpper, indexLower);
        if (angle < indexThresh)
        {
            indexStraight = true;
        }
        else indexStraight = false;

        Vector3 middleLower = middle2.position - middle1.position;
        Vector3 middleUpper = middle4.position - middle3.position;
        angle = Vector3.Angle(middleUpper, middleLower);
        if (angle < middleThresh)
        {
            middleStraight = true;
        }
        else middleStraight = false;

        Vector3 ringLower = ring2.position - ring1.position;
        Vector3 ringUpper = ring4.position - ring3.position;
        angle = Vector3.Angle(ringUpper, ringLower);
        if (angle < ringThresh)
        {
            ringStraight = true;
        }
        else ringStraight = false;

        Vector3 littleLower = little2.position - little1.position;
        Vector3 littleUpper = little4.position - little3.position;
        angle = Vector3.Angle(littleUpper, littleLower);
        if (angle < littleThresh)
        {
            littleStraight = true;
        }
        else littleStraight = false;


        //print(angle);


        //if (thumbLower.sqrMagnitude - thumbUpper.sqrMagnitude)
    }
}
