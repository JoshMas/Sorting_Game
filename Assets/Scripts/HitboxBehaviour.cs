using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxBehaviour : MonoBehaviour
{
    private int pixelWidth;
    private int pixelHeight;

    private SpriteRenderer hitboxSprite;
    private Transform hitboxTransform;
    private BoxCollider2D hitbox;
    private PlayWebcamTexture script;

    private Color storedColor;
    private Color newColor;

    // Start is called before the first frame update
    void Start()
    {
        hitboxSprite = GetComponent<SpriteRenderer>();
        hitboxTransform = GetComponent<Transform>();
        hitbox = GetComponent<BoxCollider2D>();

        script = GameObject.FindWithTag("Canvas").GetComponent<PlayWebcamTexture>();

        int canvasWidth = script.getWidth();
        int canvasHeight = script.getHeight();

        pixelWidth = (int)((9 - hitboxTransform.position.x) / 18 * canvasWidth);
        pixelHeight = (int)((hitboxTransform.position.y + 5) / 10 * canvasHeight);

        //Debug.Log(pixelWidth + "|" + pixelHeight);

        storedColor = script.getColor(pixelWidth, pixelHeight);
    }

    // Update is called once per frame
    void Update()
    {
        hitboxSprite.color = storedColor;
        newColor = script.getColor(pixelWidth, pixelHeight);
        if (Mathf.Abs(newColor.r - storedColor.r) + Mathf.Abs(newColor.b - storedColor.b) + Mathf.Abs(newColor.g - storedColor.g) < 0.3)
        {
            hitbox.isTrigger = true;
            hitboxSprite.enabled = false;
        }
        else
        {
            hitbox.isTrigger = false;
            hitboxSprite.enabled = true;
        }
        storedColor = newColor;
    }
}
