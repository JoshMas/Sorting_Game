using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{

    private int timer;

    public Object item;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ++timer;

        if (timer > 20)
        {
            timer = 0;
            Instantiate(item, new Vector3(0, 5, 0), Quaternion.identity);
        }
    }
}
