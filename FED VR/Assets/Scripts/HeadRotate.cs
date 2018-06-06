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
    public AudioSource speechAudio;
    //public string triggerName;
    // Use this for initialization
    void Start () {
        rotateTrue = true;
        shakeAnim = GetComponent<Animator>();
        speechAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        //print("Time:" + Time.time);
		if (Time.time > headTurnTime && rotateTrue == true)
        {

            //disable animation, so that rotation is possible
            shakeAnim.enabled = false;

            //play audio
            speechAudio.Play();

            //rotate the DFW character
            DFW = GameObject.Find("DFW");
            DFW.transform.Rotate(0, rotateDegree, 0, Space.World);
            Debug.Log("rotated");

            //disable the effect so it only happens once
            rotateTrue = false;
        }
	}
}
