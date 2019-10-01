using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public TextAsset category;
    public int score;
    public float itemSpeed;
    public float itemGravity;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        itemSpeed = 3.0f;
        itemGravity = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
