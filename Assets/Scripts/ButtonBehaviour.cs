using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    private Button button;

    private GameObject gameInfo;

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
        GetComponentInChildren<Text>().text = name.Split('.')[0];
    }

    void SubjectSelected(string data)
    {
        gameInfo.GetComponent<GameInfo>().subject = data;
    }
}
