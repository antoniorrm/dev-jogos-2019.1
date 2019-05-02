using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inimigoScript : MonoBehaviour
{
    GameObject jogador;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(
            this.gameObject.transform.position, 
            jogador.transform.position, 0.005f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projetil")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<pontuacaoScript>().incrementarPontos();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        } else if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<pontuacaoScript>().decrementarVidas();
        }
    }
}
