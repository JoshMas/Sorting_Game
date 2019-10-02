using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private float interval;

    public GameObject item;

    private GameInfo script;

    [SerializeField]
    private Vector3 itemSpawn;

    private void Awake()
    {
        script = GameObject.FindWithTag("Category").GetComponent<GameInfo>();
    }

    // Start is called before the first frame update
    void Start()
    {
        interval = 6.0f;
        itemSpawn = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;

        if (interval < 0)
        {
            interval = script.itemSpeed;
            GameObject newItem = Instantiate(item, itemSpawn, Quaternion.identity);
            newItem.GetComponent<ItemBehaviour>().ChangeGravity(script.itemGravity);
        }
    }
}
