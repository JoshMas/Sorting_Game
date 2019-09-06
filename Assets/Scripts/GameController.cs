using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private List<string> items;

    [SerializeField]
    private TextAsset text;

    [SerializeField]
    private List<GameObject> containerList;

    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
        string[] content = text.text.Split('\n');
        foreach (string item in content)
        {
            items.Add(item);
        }
        foreach (string item in items)
        {
            Debug.Log(item);
        }

        SetUpContainers(items[0]);
        items.RemoveAt(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetUpContainers(string containerLine)
    {
        string[] containers = containerLine.Split(new string[] { ", " }, StringSplitOptions.None);
        if (containers[0].Equals("3"))
        {
            containerList[2].SetActive(true);
        } else
        {
            containerList[2].SetActive(false);
        }
        for (int i = 0; i < Int32.Parse(containers[0]); ++i)
        {
            containerList[i].GetComponent<ContainerBehaviour>().SetCategory(containers[i + 1]);
        }
    }
}
