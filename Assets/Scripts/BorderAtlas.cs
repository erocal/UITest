using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class BorderAtlas : MonoBehaviour
{

    [SerializeField] private SpriteAtlas atlas;
    [SerializeField] private string spirteName;

    // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<Image>().sprite = atlas.GetSprite(spirteName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
