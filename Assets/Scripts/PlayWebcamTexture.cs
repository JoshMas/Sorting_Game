﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWebcamTexture : MonoBehaviour
{
    private WebCamTexture tex;
    private Color[] blocks;

    [SerializeField]
    private int blockSize;
    private int count;
    private int x;
    private int y;

    // Start is called before the first frame update
    void Start()
    {
        blockSize = 10;
        count = 0;
        x = 0;
        y = 0;
        while (y + blockSize < tex.height)
        {
            while (x + blockSize < tex.width)
            {
                ++count;
                x += blockSize;
            }
            x = 0;
            y += blockSize;
        }

        blocks = new Color[count];

        WebCamDevice[] devices = WebCamTexture.devices;

        // for debugging purposes, prints available devices to the console
        for (int i = 0; i < devices.Length; i++)
        {
            print("Webcam available: " + devices[i].name);
        }

        Renderer rend = this.GetComponentInChildren<Renderer>();

        // assuming the first available WebCam is desired
        tex = new WebCamTexture(devices[0].name);
        rend.material.mainTexture = tex;
        tex.Play();
    }

    // Update is called once per frame
    void Update()
    {
        while (y < tex.height)
        {
            while (x < tex.width)
            {

                x += blockSize;
            }
            x = 0;
            y += blockSize;
        }
    }


}
