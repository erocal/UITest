using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour
{
    private RectTransform uiRectTransform;
    private Vector2 centerPos = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

    private void Awake()
    {
        uiRectTransform = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIMoveRelative()
    {
        uiRectTransform.DOMove(new Vector2(100, 0), 0.5f).SetRelative();
    }
}
