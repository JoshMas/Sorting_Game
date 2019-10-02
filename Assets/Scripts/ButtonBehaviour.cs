using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    private Button button;

    private GameObject gameInfo;
    private string buttonName;

    private void Awake()
    {
        gameInfo = GameObject.FindWithTag("Category");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSubjectInfo(string data, string name)
    {
        button.onClick.AddListener(delegate { SubjectSelected(data); });
        buttonName = name.Split('.')[0];
        GetComponentInChildren<Text>().text = buttonName;
    }

    void SubjectSelected(string data)
    {
        gameInfo.GetComponent<GameInfo>().subject = data;
        gameInfo.GetComponent<GameInfo>().currentSubjectName = buttonName;
    }
}
