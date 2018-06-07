using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneManage : MonoBehaviour
{
    public Transform tennisBall;
    public string levelName;
    bool federerMode;
    public GameObject fedRacquet;
    public GameObject scriptCache;
    public float smallBallSize;
    public float largeFedBallSize;

    void Start()
    {
        federerMode = false;

        //slow mo not activated till FED racquet picked up
        scriptCache.GetComponent<FINALsuperHotTimeEffect>().enabled = false;
    }

    void Update()
    {
        //print("Grabbed?" + fedRacquet.GetComponent<OVRGrabbable>().isGrabbed);
        //if federer racquet is grabbed, then
        if (fedRacquet.GetComponent<OVRGrabbable>().isGrabbed == true)
        {
            federerMode = true;
        }
        else
        {
            federerMode = false;
        }


    }
   public void newBall()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
        //SceneManager.LoadScene(levelName);

        //spawn new tennis ball NORM Mode
        if (federerMode == false)
        {
            tennisBall.transform.localScale = new Vector3(1*smallBallSize,1*smallBallSize,1*smallBallSize);
            tennisBall.GetComponent<BallSizeChange>().enabled = false;
            scriptCache.GetComponent<FINALsuperHotTimeEffect>().enabled = false;
            Instantiate(tennisBall, new Vector3(-0.869f, 1.16f, -2.87f), Quaternion.identity);
        }

        //spawn new tennis ball FED Mode
        if (federerMode == true)
        {
            tennisBall.transform.localScale = new Vector3(1*largeFedBallSize,1*largeFedBallSize,1*largeFedBallSize);
            tennisBall.GetComponent<BallSizeChange>().enabled = true;
            scriptCache.GetComponent<FINALsuperHotTimeEffect>().enabled = true;
            Instantiate(tennisBall, new Vector3(-0.869f, 1.16f, -2.87f), Quaternion.identity);
        }
    }

    public void SceneChangeOnClick()
    {
        SceneManager.LoadScene(levelName);
    }


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelName);
        print("OBJECT NAME" + other.gameObject.name);
    }
}