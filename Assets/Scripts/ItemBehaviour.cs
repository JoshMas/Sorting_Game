using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public string text;
    int category;

    // Start is called before the first frame update
    void Start()
    {
        category = Random.Range(0, 2);
        text = "" + category;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
