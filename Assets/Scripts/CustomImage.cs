using UnityEngine;
using UnityEngine.UI;

public class CustomImage : Image
{
    [Header("自訂調整數值")]
    [Tooltip("是否使用第一個獲取的Collider2D作為觸發範圍")]
    [SerializeField] private bool useCollider2D;

    [Tooltip("透明度檢測的閾值")]
    [SerializeField, Range(0, 1f)] private float alphaHitTestMinimumThreshold;

    private Collider2D currentCollider2D;

    private void Update()
    {
        base.alphaHitTestMinimumThreshold = alphaHitTestMinimumThreshold;
        GetCurrentCollider2D();
    }

    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        bool isRaycast = base.IsRaycastLocationValid(screenPoint, eventCamera);

        if (isRaycast && currentCollider2D != null)
        {
            return currentCollider2D.OverlapPoint(screenPoint);
        }

        return isRaycast;
    }

    private void GetCurrentCollider2D()
    {
        if (useCollider2D) currentCollider2D = GetComponent<Collider2D>();
        else currentCollider2D = null;
    }
}
