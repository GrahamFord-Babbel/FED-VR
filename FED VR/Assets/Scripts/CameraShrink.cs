using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraShrink : MonoBehaviour
{
    public GameObject ShrinkPoint;
    public GameObject GrowthPoint;
    float countdown;
    public float countdownTime;
    bool startcount = false;
    public GameObject foodText;
    //Renderer rend;
    Text originalText;
    Color newColor;
    Animator anim;
    AudioSource TrouperRawr;
    GameObject troupes;
    GameObject babbelWhoops;
    // Use this for initialization
    void Start()
    {
        foodText.SetActive(false);
        anim = GameObject.Find("Trouper Cube Path").GetComponent<Animator>();
        troupes = GameObject.Find("Trouper");
        babbelWhoops = GameObject.Find("Rock 5.19");
    }

    // Update is called once per frame
    void Update()
    {
        originalText = foodText.GetComponent<Text>();
        if (startcount == true) {
            //print(countdown);
            countdown += Time.deltaTime;
            newColor = new Color(Random.value, Random.value, Random.value);
            //print(newColor);
            originalText.color = newColor;
            if (countdown > countdownTime)
            {
            print(Time.deltaTime);
                Camera.main.transform.parent.transform.position = GrowthPoint.transform.position;
                startcount = false;
                foodText.SetActive(false);
                babbelWhoops.GetComponent<AudioSource>().Play();
                countdown = 0;
            }
        }
    }

    public void ClickShrink()
    {
        startcount = true;
        Camera.main.transform.parent.transform.position = ShrinkPoint.transform.position;
        //print(countdown);
        foodText.SetActive(true);
        anim.Play(0,0);
        TrouperRawr = troupes.GetComponent<AudioSource>();
        TrouperRawr.Play();
    }
}
