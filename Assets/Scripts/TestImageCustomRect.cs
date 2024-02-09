using UnityEngine;
using UnityEngine.UI;


public class TestImageCustomRect : Image
{
    private CapsuleCollider2D collider2d;
    void Awake()
    {
        collider2d = GetComponent<CapsuleCollider2D>();
    }
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        bool isRay = base.IsRaycastLocationValid(screenPoint, eventCamera);
        if (isRay && (collider2d != null))
        {
            bool isTrig = collider2d.OverlapPoint(screenPoint);
            return isTrig;
        }
        return isRay;
    }
}