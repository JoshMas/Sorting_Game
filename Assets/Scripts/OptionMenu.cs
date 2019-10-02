using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    private GameInfo script;
    [SerializeField]
    private List<Slider> sliders;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindWithTag("Category").GetComponent<GameInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetItemSpeed(float value)
    {
        script.itemSpeed = sliders[0].value;
        Debug.Log("" + script.itemSpeed);
    }

    public void SetGravity(float value)
    {
        script.itemGravity = sliders[1].value;
        Debug.Log("" + script.itemGravity);
    }

    public void SetGameTime(float value)
    {
        script.gameTime = sliders[2].value + 6;
        Debug.Log("" + script.gameTime);
    }

    public void ResetToDefault()
    {
        script.itemSpeed = 6.0f;
        sliders[0].value = 6.0f;
        script.itemGravity = 0.5f;
        sliders[1].value = 0.5f;
        script.gameTime = 66.0f;
        sliders[2].value = 66.0f;
    }
}
