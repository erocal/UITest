using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    [Header(" UI ")]
    [Tooltip("UI文字_經過的時間")]
    [SerializeField] TextMeshProUGUI Text_PassTime;

    #region -- 參數參考區 --

    private float passFixedDeltaTime = 0f;

    #endregion

    private void FixedUpdate()
    {
        CountFixedDeltaTime();
        SetTextPassTime();
    }

    // 這個方法會在每個GUI事件循環中被調用
    void OnGUI()
    {
        // 如果按下了"Pause"按鈕
        if (GUI.Button(new Rect(10, 10, 100, 50), "Time Pause"))
        {
            TimePause();
        }
        if (GUI.Button(new Rect(10, 70, 100, 50), "Time Run"))
        {
            TimeRun();
        }
    }

    #region -- 方法參考區 --

    /// <summary>
    /// 暫停時間
    /// </summary>
    private void TimePause()
    {
        Time.timeScale = 0f;
    }

    /// <summary>
    /// 時間正常流動
    /// </summary>
    private void TimeRun()
    {
        Time.timeScale = 1f;
    }

    /// <summary>
    /// 累加FixedDeltaTime
    /// </summary>
    private void CountFixedDeltaTime()
    {
        passFixedDeltaTime += Time.fixedDeltaTime;
    }

    /// <summary>
    /// 設定Text_PassTime文字
    /// </summary>
    private void SetTextPassTime()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("PassTime : ");
        stringBuilder.Append((int)passFixedDeltaTime);

        if (Text_PassTime != null)
        {
            Text_PassTime.text = stringBuilder.ToString();
        }
    }

    #endregion
}
