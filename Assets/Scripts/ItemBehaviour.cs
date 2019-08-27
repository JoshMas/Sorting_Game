using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    private int category;
    SpriteRenderer itemSprite;

    // Start is called before the first frame update
    void Start()
    {
        itemSprite = GetComponent<SpriteRenderer>();
        category = Random.Range(0, 2);
        if (category == 0)
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

    public bool MatchesCategory(int container)
    {
        return container == category;
    }
}
