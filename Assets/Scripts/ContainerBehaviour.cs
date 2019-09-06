using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerBehaviour : MonoBehaviour
{
    [SerializeField]
    private string category;

    [SerializeField]
    private AudioSource correct;
    private bool cPlay;

    [SerializeField]
    private AudioSource incorrect;
    private bool iPlay;

    private TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        cPlay = false;
        iPlay = false;
        text = GetComponentInChildren<TextMesh>();
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

    public void SetCategory(string newCategory)
    {
        category = newCategory;
        text.text = newCategory;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ItemBehaviour>().MatchesCategory(category))
        {
            cPlay = true;
        }
        else
        {
            iPlay = true;
        }
    }
}
