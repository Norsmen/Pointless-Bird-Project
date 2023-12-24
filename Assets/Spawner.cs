using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float timer;
    private float baseTimer;
    void Start()
    {
        GameObject go = Instantiate( pipe, transform);
        go.transform.position = new Vector2(go.transform.position.x, Random.Range(-1f, 4f));
        baseTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            GameObject go = Instantiate( pipe, transform);
            go.transform.position = new Vector2(go.transform.position.x, Random.Range(-1f, 4f));
            timer = baseTimer;
        }


    }
}
