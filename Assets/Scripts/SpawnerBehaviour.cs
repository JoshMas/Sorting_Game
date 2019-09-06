using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{

    private float interval;

    public Object item;

    // Start is called before the first frame update
    void Start()
    {
        interval = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;

        if (interval < 0)
        {
            interval = 3.0f;
            Instantiate(item, new Vector3(0, 5, 0), Quaternion.identity);
        }
    }
}
