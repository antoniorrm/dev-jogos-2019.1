using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetilScript : MonoBehaviour
{
    float tempoInicio;
    // Start is called before the first frame update
    void Start()
    {
        tempoInicio = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - tempoInicio > 2.0f )
        {
            Destroy(this.gameObject);
        }
    }
}
