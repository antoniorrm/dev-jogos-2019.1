using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogadorScript : MonoBehaviour
{
    public GameObject prefabProjetil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.forward * 0.1f);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.forward * -0.1f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(-Vector3.up);
        }

        if (Input.GetKeyDown (KeyCode.Space))
        {
            GameObject go = Instantiate(prefabProjetil) as GameObject;
            go.transform.position = this.gameObject.transform.position + this.gameObject.transform.forward;
            go.transform.rotation = this.gameObject.transform.rotation;
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * 2000f);
        }
    }
}
