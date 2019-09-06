﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerBehaviour : MonoBehaviour
{
    [SerializeField]
    private int category;

    [SerializeField]
    private AudioSource correct;
    private bool cPlay;

    [SerializeField]
    private AudioSource incorrect;
    private bool iPlay;

    // Start is called before the first frame update
    void Start()
    {
        cPlay = false;
        iPlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cPlay)
        {
            correct.Play();
            cPlay = false;
        }
        if (iPlay)
        {
            incorrect.Play();
            iPlay = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ItemBehaviour>().MatchesCategory(category))
        {
            cPlay = true;
            ScoreScript.scoreValue += 10;
        }
        else
        {
            iPlay = true;
            ScoreScript.scoreValue -= 1;
        }
    }
}
