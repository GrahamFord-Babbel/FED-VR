using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class FINALsuperHotTimeEffect : MonoBehaviour
{
    private float slowMo = 0.2f;
    private float normTime = 1.0f;
    private bool doSlowMo = false;

    [SerializeField]
    private OVRPlayerController player;
    [SerializeField]
    private Text textUI;

    void Update()
    {
        if (player.Controller.velocity.magnitude > 0)
        {
            print("player velocity" + player.Controller.velocity.magnitude);
            if (doSlowMo)
            {
                Time.timeScale = normTime;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                textUI.text = Time.timeScale.ToString("1");
                doSlowMo = false;
            }
        }
        else
        {
            if (!doSlowMo)
            {
                Time.timeScale = slowMo;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                textUI.text = Time.timeScale.ToString("0");
                doSlowMo = true;
            }
        }
    }
}