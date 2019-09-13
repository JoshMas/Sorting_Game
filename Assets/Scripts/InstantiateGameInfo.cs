using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGameInfo : MonoBehaviour
{

    [SerializeField]
    private GameObject gameInfo;

    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.FindWithTag("Category") == null)
        {
            Instantiate<GameObject>(gameInfo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
