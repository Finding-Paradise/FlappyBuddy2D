using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAppearence : MonoBehaviour
{
    public Transform CloudSize;
    public SpriteRenderer CloudTransparency;
    private float maxScale = 2.2f;
    private float minScale = 0.8f;
    float cloudOpacity;
    float generatedScale;
    // Start is called before the first frame update

    public float GetCloudOpacity(float generatedScale) =>
        generatedScale switch
        {
            float i when i >= 0.8 && i < 1.2 => 0.2f,
            float i when i >= 1.2 && i < 1.5 => 0.5f,
            float i when i >= 1.5 && i < 1.9 => 0.8f,
            _ => 1f
        };


    void Start()
    {
        generatedScale = Random.Range(minScale, maxScale);
        cloudOpacity = GetCloudOpacity(generatedScale);


        CloudSize.transform.localScale = new Vector2(generatedScale, generatedScale);
        CloudTransparency.color = new Color(1f, 1f, 1f, cloudOpacity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
