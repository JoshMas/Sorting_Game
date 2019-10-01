using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOnClick : MonoBehaviour
{
    [SerializeField]
    private List<TextAsset> categories;

    private GameObject gameInfo;

    private void Awake()
    {
        gameInfo = GameObject.FindWithTag("Category");
    }

    public void MathSelected()
    {
        gameInfo.GetComponent<GameInfo>().category = categories[0];
    }

    public void GeoSelected()
    {
        gameInfo.GetComponent<GameInfo>().category = categories[1];
    }
}
