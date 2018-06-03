using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHotTimeEffect : MonoBehaviour {
    //public float TimeFrozen;
    //public float TimeUnfrozen;
    //Vector3 PreviousControllerLocation;
    //Vector3 CurrentControllerLocation;
    //float ControllerPositionChange;
    //Vector3 CurrentControllerAcceleration;
    //Vector3 PreviousControllerAcceleration;

    //// Use this for initialization
    //void Start() {
    //    PreviousControllerAcceleration = OVRInput.GetLocalControllerAcceleration(OVRInput.Controller.LTouch);
    //    Debug.Log("PrevAccel:" + CurrentControllerAcceleration);

    //}

    //// Update is called once per frame
    //void Update() {

    //    CurrentControllerAcceleration = OVRInput.GetLocalControllerAcceleration(OVRInput.Controller.LTouch);
    //    Debug.Log("CurAccel:" + CurrentControllerAcceleration);
    //    Debug.Log("PrevAccel:" + CurrentControllerAcceleration);

    //    if (Mathf.Approximately(CurrentControllerAcceleration.x == PreviousControllerAcceleration.x))
    //    {
    //        print(true);
    //        Time.timeScale = TimeFrozen;
    //    }
    //    else
    //    {
    //        print(false);
    //        Time.timeScale = TimeUnfrozen;

    //    }

    //    PreviousControllerLocation = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
    //    //Debug.Log("PrevControllerPosition:" + PreviousControllerLocation);
    //    CurrentControllerLocation = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
    //    //Debug.Log("CurControllerPosition:" + CurrentControllerLocation);

    //    OVRInput.Update();

    //    ControllerPositionChange = Vector3.Distance(PreviousControllerLocation, CurrentControllerLocation);
    //    //Debug.Log("ControllerPositionChange:" + ControllerPositionChange);

    //    //need to code the distance between "past controller state" and "current controller state" and if it is greater than 
    //    //"past controller state" + 1(or whatever), then we move time. (do the same thing as size)

    //    //could try rounding the vector axis and if it changes by a whole number time registers...?

    //    //try accessing "Acceleration"? - OVRInput.GetLocalControllerAcceleration

    //    // or hacking into the PlayerController to see if an event Updated has occured


    //    //if (CurrentControllerLocation > Vector3.Distance(PreviousControllerLocation, new Vector3(ControllerPositionChange, ControllerPositionChange, ControllerPositionChange)));
    //    //if (ControllerPositionChange > 1) ;
    //    //{
    //    //    Time.timeScale = TimeFrozen;
    //    //}
    //    //if (Input.anyKey == true)
    //    //{
    //    //    Time.timeScale = TimeUnfrozen;
    //    //}
    //}
}
