using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    GameObject finishText;
  
    float time = 30.0f;
    int point = 0;

    public void TouchPurple()
    {
        this.point += 5000;
    }
    public void TouchRed()
    {
        this.point += 1000;
    }
    public void TouchBlue()
    {
        this.point += 500;
    }
    public void TouchGreen()
    {
        this.point += 100;
    }
    


    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("point");
        this.finishText = GameObject.Find("Finish");
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
        this.finishText.GetComponent<Text>().enabled = false;

        if (this.time <= 1)
        {
            this.finishText.GetComponent<Text>().enabled = true;
            

        }
       
    }
}
