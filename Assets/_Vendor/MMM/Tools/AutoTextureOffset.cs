using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoTextureOffset : MonoBehaviour {

    Renderer renderer;
    RawImage rawImage;
    public Vector2 speed = Vector2.zero;

    // Use this for initialization
    void Start () {
        if (renderer == null)
        {
            renderer = GetComponent<Renderer>();
        }
        if(rawImage == null)
        {
            rawImage = GetComponent<RawImage>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(renderer != null)
        {
            var offset = renderer.sharedMaterial.mainTextureOffset;
            offset += speed;
            renderer.sharedMaterial.mainTextureOffset = offset;
        }

        if (rawImage != null)
        {
            var offset = rawImage.material.mainTextureOffset;
            offset += speed;
            rawImage.material.mainTextureOffset = offset;
        }


    }
}
