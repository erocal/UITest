using UnityEngine;
using UnityEngine.UI;

public class CustomImage : Image
{
    [Header("�ۭq�վ�ƭ�")]
    [Tooltip("�O�_�ϥβĤ@�������Collider2D�@��Ĳ�o�d��")]
    [SerializeField] private bool useCollider2D;

    [Tooltip("�z�����˴����H��")]
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
