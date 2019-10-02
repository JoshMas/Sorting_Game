using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameInfo script = GameObject.FindWithTag("Category").GetComponent<GameInfo>();
        this.GetComponent<Text>().text = "Current Subject: " + script.currentSubjectName + "\nPrevious Score: " + script.score;
        Debug.Log(script.currentSubjectName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
