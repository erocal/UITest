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

    [SerializeField] List<Sprite> sprite_Number;

    int count = 3;
    bool isAdd;

    private float time = -1f;

    private void FixedUpdate()
    {

        time += Time.fixedDeltaTime;
        time %= 1f;

        Flip();
    }

    private void Flip()
    {
        if (time <= 0.1f)
        {
            nextTime_Units_Digit_Upper.sprite = sprite_Number[count - 1];
            nextTime_Units_Digit_Lower.sprite = sprite_Number[count];
        }

        if(time <= 0.4f)
        {

            isAdd = false;
            nextTime_Units_Digit_Lower.rectTransform.sizeDelta = new Vector2(nextTime_Units_Digit_Lower.rectTransform.sizeDelta.x, 0);

            float newHeight = Mathf.Lerp(15, 0, time / 0.5f); // 使用插值逐漸調整高度
            currentTime_Units_Digit_Upper.rectTransform.sizeDelta = new Vector2 (currentTime_Units_Digit_Upper.rectTransform.sizeDelta.x, newHeight);
        }
        else
        {
            currentTime_Units_Digit_Upper.rectTransform.sizeDelta = new Vector2(currentTime_Units_Digit_Upper.rectTransform.sizeDelta.x, 0);

            float newHeight = Mathf.Lerp(0, 15, time / 0.5f); // 使用插值逐漸調整高度
            nextTime_Units_Digit_Lower.rectTransform.sizeDelta = new Vector2(nextTime_Units_Digit_Lower.rectTransform.sizeDelta.x, newHeight);
        }

        if(time > 0.9f && !isAdd)
        {
            isAdd = true;
            currentTime_Units_Digit_Upper.sprite = sprite_Number[count-1];
            currentTime_Units_Digit_Lower.sprite = sprite_Number[count];

            currentTime_Units_Digit_Upper.rectTransform.sizeDelta = new Vector2(currentTime_Units_Digit_Upper.rectTransform.sizeDelta.x, 15);
            nextTime_Units_Digit_Lower.rectTransform.sizeDelta = new Vector2(nextTime_Units_Digit_Lower.rectTransform.sizeDelta.x, 0);

            count += 2;
            if (count > sprite_Number.Count) count = 1;

        }
    }
}
