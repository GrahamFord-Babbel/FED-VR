using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSizeChange : MonoBehaviour
{
    public GameObject Racquet;
    public GameObject Backboard;
    float distanceFromRacquet;
    float distanceFromBackboard;
    Vector3 RacquetPos;
    Vector3 TennisBallPos;
    Vector3 initialBallScale;
    Vector3 newBallScale;
    float positiveChecker;
    // Use this for initialization
    void Start()
    {
        //determine initial positions of tennis ball & racquet
        RacquetPos = Racquet.transform.position;
        TennisBallPos = transform.position;
        Debug.Log("Tennis Ball Position:" + TennisBallPos);
        Debug.Log("Racquet Position:" + RacquetPos);

        //determine initial scale of tennis ball
        initialBallScale = transform.localScale;
        Debug.Log("Initial ball scale:" + initialBallScale);


        //determine initial distance of racquet from backboard
        distanceFromBackboard = Vector3.Distance(Racquet.transform.position, Backboard.transform.position);
        Debug.Log("Distance 4 Backboard:" + distanceFromBackboard);

        //shits
        positiveChecker = transform.localScale.x;
        Debug.Log("positiveChecker" + positiveChecker);
    }

    // Update is called once per frame
    void Update()
    {

        //distance 
        distanceFromRacquet = Vector3.Distance(Racquet.transform.position, transform.position);
        distanceFromRacquet = distanceFromRacquet / 10;
        //Debug.Log("Distance 4 Racquet:" + distanceFromRacquet);

        //make sure ball is still large enough to keep shrinking (dont want negative)
        positiveChecker = transform.localScale.x;
        //Debug.Log("positiveChecker" + positiveChecker);

        //if (positiveChecker > 0 && distanceFromRacquet > 1 || distanceFromRacquet > 5)
        if (positiveChecker > 0 && distanceFromRacquet > .25)
        {
            newBallScale = new Vector3(distanceFromRacquet, distanceFromRacquet, distanceFromRacquet);
            transform.localScale = initialBallScale - newBallScale;
            //Debug.Log("New Scale:" + transform.localScale + "should shrink, then grow");
        }
    }
}