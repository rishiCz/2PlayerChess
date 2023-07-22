using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timers : MonoBehaviour
{
    public TMP_Text texttime;
    public Color white= new Color(1f,1f,1f);
    public Color black= new Color(0.5882353f,0.4941177f,0.4627451f);
    private static float timer=0f;
    public static bool timeon=false;

    // Update is called once per frame
    void Update()
    {
        if(timeon)    timer+=Time.deltaTime*2;
        DisplayTime();
    }
    void DisplayTime(){
        int min=Mathf.FloorToInt(timer/60f);
        int sec=Mathf.FloorToInt(timer-min*60f);
        texttime.text=string.Format("{0:00}:{1:00}",min,sec);
        if(Active.whiteT)   texttime.color=white;
        else    texttime.color=black;
    }
    public static void resetTime(){
        timer=0f;
    }
    public static void stop(){
        timeon=false;
        resetTime();
    }
}
