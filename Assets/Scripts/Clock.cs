using System;
using UnityEngine;

public class Clock: MonoBehaviour
{
    [SerializeField] private Transform hoursPivot = null, minutesPivot = null, secondPivot = null;

    private const float HoursToDegrees = -30f;
    private const float MinutesToDegrees = -6f;
    private const float SecondToDegrees = -6f;

    private void Update()
    {
        // var time = DateTime.Now;
        // hoursPivot.localRotation = Quaternion.Euler(0f, 0f, HoursToDegrees * time.Hour);
        // minutesPivot.localRotation = Quaternion.Euler(0f, 0f, MinutesToDegrees * time.Minute);
        // secondPivot.localRotation = Quaternion.Euler(0f, 0f, SecondToDegrees * time.Second);
        var time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, HoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, MinutesToDegrees * (float)time.TotalMinutes);
        secondPivot.localRotation = Quaternion.Euler(0f, 0f, SecondToDegrees * (float)time.TotalSeconds);
    }
}