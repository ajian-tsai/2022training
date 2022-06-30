using System;
using UnityEngine;
public class Clock: MonoBehaviour
{
    [SerializeField] //����public
    Transform hoursAngle,minuteAngle,SecondAngle;

    void Update()
    {
        Debug.Log(DateTime.Now); //�n��DateTime�����[System�ADateTime.Now�i�H�����p�ɤ����L�X��
        //Debug.Log(DateTime.Now.Hour);
        int h = DateTime.Now.Hour;
        int s = DateTime.Now.Second;
        int m = DateTime.Now.Minute;
        hoursAngle.localRotation = Quaternion.Euler(0,0,-30*h);///����i�H�Ψ�Quaternion
        minuteAngle.localRotation = Quaternion.Euler(0, 0, -6*m);
        SecondAngle.localRotation = Quaternion.Euler(0, 0, -6*s);
    }


}