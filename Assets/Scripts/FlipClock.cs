using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipClock : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] Image nextTime_Units_Digit_Upper;
    [SerializeField] Image currentTime_Units_Digit_Upper;
    [SerializeField] Image currentTime_Units_Digit_Lower;
    [SerializeField] Image nextTime_Units_Digit_Lower;

    private float time;

    private void Fixedpdate()
    {
        time += Time.fixedDeltaTime;
        if(time > 1f) time %= 1f;
    }

    private void Flip()
    {

    }
}
