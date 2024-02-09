using UnityEngine;
using UnityEngine.UI;

public class ImageAlphaThersholdChange : MonoBehaviour
{
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image.alphaHitTestMinimumThreshold = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
