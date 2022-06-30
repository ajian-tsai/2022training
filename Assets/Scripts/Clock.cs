using System;
using UnityEngine;
public class Clock: MonoBehaviour
{
    [SerializeField] //類似public
    Transform hoursAngle,minuteAngle,SecondAngle;

    void Update()
    {
        Debug.Log(DateTime.Now); //要用DateTime必須加System，DateTime.Now可以把日期小時分秒都印出來
        //Debug.Log(DateTime.Now.Hour);
        int h = DateTime.Now.Hour;
        int s = DateTime.Now.Second;
        int m = DateTime.Now.Minute;
        hoursAngle.localRotation = Quaternion.Euler(0,0,-30*h);///旋轉可以用到Quaternion
        minuteAngle.localRotation = Quaternion.Euler(0, 0, -6*m);
        SecondAngle.localRotation = Quaternion.Euler(0, 0, -6*s);
    }


}