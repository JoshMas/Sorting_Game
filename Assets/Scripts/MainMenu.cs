using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = "Previous Score: " + GameObject.FindWithTag("Category").GetComponent<GameInfo>().score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
