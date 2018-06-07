using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowFlash : MonoBehaviour
{

    //float countdown;
    //public float countdownTime;
    //public GameObject foodText;
    //Renderer rend;
    //GameObject originalText;
    Color newColor;
    Color originalColor;
    float changeTime;
    int colorTicker;

    void Start()
    {
        originalColor = Color.white;
        newColor = Color.red;
    }


    // Update is called once per frame
    void Update()
    {
        changeTime = changeTime + Time.deltaTime;
        if (changeTime > 0.5) {
            
            if (colorTicker % 2 == 0)
            {
                GetComponent<Renderer>().material.color = originalColor;
            }
            if (colorTicker % 2 == 1)
            {
                GetComponent<Renderer>().material.color = newColor;
            }
            //originalText = foodText.GetComponent<GameObject>();
            //print(countdown);
            //countdown += Time.deltaTime;
            //print(newColor);
            //originalText.GetComponent<Renderer>().material.color = newColor;
            changeTime = 0;
            colorTicker += 1;
        }
    }
}
