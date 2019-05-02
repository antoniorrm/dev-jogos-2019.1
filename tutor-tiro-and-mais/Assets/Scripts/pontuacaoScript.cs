using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pontuacaoScript : MonoBehaviour
{
    int pontos;
    int vidas;
    public Text pontosUI;
    public Text vidasUI;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        vidas = 5;
    }

    // Update is called once per frame
    void Update()
    {
        vidasUI.text = vidas.ToString();
    }

    public void incrementarPontos()
    {
        this.pontos++;
        pontosUI.text = pontos.ToString();
        //Debug.Log(this.pontos);
    }

    public void decrementarVidas()
    {
        this.vidas--;
        vidasUI.text = vidas.ToString();
        Debug.Log(this.vidas);
        if (vidas == 0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }

}
