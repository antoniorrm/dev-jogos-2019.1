using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject inimigoPrefab;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - time > 3.0f)
        {
            GameObject go = Instantiate(inimigoPrefab) as GameObject;
            go.gameObject.transform.position = new Vector3(Random.Range(-3.0f, 3.0f), 0.5f, Random.Range(-3.0f, 3.0f));
            time = Time.time;
        }
    }
}
