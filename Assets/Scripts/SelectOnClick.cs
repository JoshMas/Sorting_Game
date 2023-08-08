using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SelectOnClick : MonoBehaviour
{
    [SerializeField]
    private List<TextAsset> categories;

    private List<string> subjects;

    private GameObject gameInfo;
    private GameObject scroll;

    [SerializeField]
    private GameObject button;

    private void Awake()
    {
        gameInfo = GameObject.FindWithTag("Category");
    }
    
    private void Start()
    {
        subjects = new List<string>();
        scroll = GameObject.FindGameObjectWithTag("Scroll");
        int count = 0;

        string[] files = new string[0];

        if (Directory.Exists("Subjects"))
        {
            files = Directory.GetFiles("Subjects");
        }
        else if (Directory.Exists("../Subjects"))
        {
            files = Directory.GetFiles("../Subjects");
        }
        else
        {
            files = Directory.GetFiles(Application.streamingAssetsPath);
        }

        
        foreach (string path in files)
        {
            StreamReader reader = new StreamReader(path);
            subjects.Add(reader.ReadToEnd());
            GameObject newButton = Instantiate(button, new Vector3((count * Screen.width / 5) + Screen.width / 10, Screen.height / 2), Quaternion.identity, scroll.transform);
            newButton.GetComponent<ButtonBehaviour>().AddSubjectInfo(subjects[subjects.Count - 1], Path.GetFileName(path));
            ++count;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            scroll.transform.Translate(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            scroll.transform.Translate(Vector3.right);
        }
    }

    /*
    public void SubjectSelected(int index)
    {
        gameInfo.GetComponent<GameInfo>().subject = subjects[index];
    }

    
    public void MathSelected()
    {
        gameInfo.GetComponent<GameInfo>().category = categories[0];
    }

    public void GeoSelected()
    {
        gameInfo.GetComponent<GameInfo>().category = categories[1];
    }
    */
}
