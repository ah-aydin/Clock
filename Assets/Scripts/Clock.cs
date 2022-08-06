using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegreese = -6f;

    private void Update()
    {
        var time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegreese * (float) time.TotalSeconds);
    }
}
