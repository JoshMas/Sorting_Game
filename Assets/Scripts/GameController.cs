using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private float timer;
    private List<string> items;
    /*
    [SerializeField]
    private TextAsset text;
    */
    [SerializeField]
    private string subject;

    [SerializeField]
    private List<GameObject> containerList;

    [SerializeField]
    private GameObject banner;

    private GameObject gameInfo;

    private void Awake()
    {
        gameInfo = GameObject.FindWithTag("Category");
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        if (gameInfo != null)
        {
            //text = gameInfo.GetComponent<GameInfo>().category;
            subject = gameInfo.GetComponent<GameInfo>().subject;
        }

        items = new List<string>();
        string[] content = subject.Split('\n');
        foreach (string item in content)
        {
            items.Add(item);
        }
        /*
        foreach (string item in items)
        {
            Debug.Log(item);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (containerList[0].GetComponent<ContainerBehaviour>().HasNoCategory())
        {
            SetUpContainers(items[0]);
        }
        timer += Time.deltaTime;
        if (timer > 2 && timer < 4)
        {
            banner.GetComponent<Text>().text = "2";
        }
        if (timer > 4 && timer < 6)
        {
            banner.GetComponent<Text>().text = "1";
        }
        if (timer > 6 && timer < 7)
        {
            banner.GetComponent<Text>().text = "";
        }
        if (timer > 6)
        {
            ScoreScript.timerValue -= Time.deltaTime;
        }
        if (timer > 66 && gameInfo != null)
        {
            GameObject.FindWithTag("Canvas").GetComponent<PlayWebcamTexture>().StopWebCam();
            GetComponent<AudioSource>().Stop();
            gameInfo.GetComponent<GameInfo>().score = ScoreScript.scoreValue;
            ScoreScript.scoreValue = 0;
            ScoreScript.timerValue = 60.0f;
            SceneManager.LoadScene("MainMenu");
        }
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

    public string GetRandomItem()
    {
        return items[UnityEngine.Random.Range(1, items.Count)];
    }
}
