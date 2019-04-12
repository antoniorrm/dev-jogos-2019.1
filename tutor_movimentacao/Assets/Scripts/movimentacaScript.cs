using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 0.2f;
    public float impulse = 50f;
    bool jumping = false;
    void Start()
    {
        jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += this.gameObject.transform.right * velocity;
        } else if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += this.gameObject.transform.right * -velocity;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.position += this.gameObject.transform.forward * velocity;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.position += this.gameObject.transform.forward * -velocity;
        }

        if (Input.GetKey(KeyCode.Space) && !jumping)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.up * impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumping = false;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumping = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "sphere")
        {
            Destroy(collision.gameObject);
        }
    }

}
