using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryInfo : MonoBehaviour
{
    public TextAsset category;
    public int score;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
