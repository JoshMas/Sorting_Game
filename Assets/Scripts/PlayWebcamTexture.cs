using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWebcamTexture : MonoBehaviour
{
    private WebCamTexture tex;
    private Color[] blocks;
    public Object item;
    private Object[] hitboxes;
    [SerializeField]
    private float blockSize;
    private int count;
    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        

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

        count = 0;
        x = 0;
        y = 0;
        while (y + blockSize < 10 + blockSize)
        {
            while (x + blockSize < 18 + blockSize)
            {
                Instantiate(item, new Vector3(x - 9 + blockSize/2, y - 5 + blockSize/2, 0), Quaternion.identity);
                count++;
                x += blockSize;
                //Debug.Log("" + count);
            }
            x = 0;
            y += blockSize;
        }

        blocks = new Color[count];

        tex.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(tex.width + "|" + tex.height);
    }

    public int GetWidth()
    {
        return tex.width;
    }

    public int GetHeight()
    {
        return tex.height;
    }

    public Color GetColor(int x, int y)
    {
        if (tex.isPlaying)
        {
            return tex.GetPixel(x, y);
        }
        else
        {
            return new Color(0, 0, 0);
        }
    }

    public void StopWebCam()
    {
        tex.Stop();
    }
}
