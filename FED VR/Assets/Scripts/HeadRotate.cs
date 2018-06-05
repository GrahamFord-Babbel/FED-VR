using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotate : MonoBehaviour {
    GameObject DFW;
    public float rotateDegree;
    bool rotateTrue;
    public float headTurnTime;
    //public Animation anim;
    public Animator shakeAnim;
    //public string triggerName;
    // Use this for initialization
    void Start () {
        rotateTrue = true;

    }
	
	// Update is called once per frame
	void Update () {
        //print("Time:" + Time.time);
		if (Time.time > headTurnTime && rotateTrue == true)
        {
            shakeAnim = GetComponent<Animator>();
            //Animation.enabled = false;
            shakeAnim.enabled = false;
            DFW = GameObject.Find("DFW");
            DFW.transform.Rotate(0, rotateDegree, 0, Space.World);
            Debug.Log("rotated");
            rotateTrue = false;
        }
	}
}
