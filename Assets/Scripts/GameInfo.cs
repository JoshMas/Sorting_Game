﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameInfo : MonoBehaviour
{
    //public TextAsset category;
    public string subject;
    public string currentSubjectName;
    public int score;
    public float itemSpeed;
    public float itemGravity;
    public float gameTime;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        string path = "";
        if (Directory.Exists("Subjects"))
        {
            path = Directory.GetFiles("Subjects")[0];
        }
        else if (Directory.Exists("../Subjects"))
        {
            path = Directory.GetFiles("../Subjects")[0];
        }
        else
        {
            path = Directory.GetFiles(Application.streamingAssetsPath)[0];
        }
        StreamReader reader = new StreamReader(path);
        subject = reader.ReadToEnd();
        currentSubjectName = Path.GetFileName(path).Split('.')[0];
        score = 0;
        itemSpeed = 3.0f;
        itemGravity = 0.5f;
        gameTime = 66.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
