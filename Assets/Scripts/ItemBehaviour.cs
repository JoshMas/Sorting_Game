using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    private string category;
    private SpriteRenderer itemSprite;
    private TextMesh text;

    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        text = GetComponentInChildren<TextMesh>();
        
        string[] itemContent = gameController.GetRandomItem().Split(new string[] { ", " }, StringSplitOptions.None);
        text.text = itemContent[0];
        category = itemContent[1];

        itemSprite = GetComponent<SpriteRenderer>();
        int colour = UnityEngine.Random.Range(0, 2);
        if (colour == 0)
        {
            itemSprite.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    public bool MatchesCategory(string container)
    {
        return container.Equals(category);
    }
}
