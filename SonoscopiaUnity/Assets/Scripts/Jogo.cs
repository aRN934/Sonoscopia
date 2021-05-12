using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jogo : MonoBehaviour
{

    [SerializeField] 
    Transform[] coordenadas = new Transform[4];

    [SerializeField]
    GameObject coletavel;
    public bool instanciar = true;

    private int[] preenchidos = new int[4];

    private int contaPreenchidos = 0;

    private int pontos = 0;
    [SerializeField]
    Text textoPontos;

    void Start()
    {
        ResetPreenchidos();
    }

    // Update is called once per frame
    void Update()
    {
        if (instanciar) InstanciaColetavel();
    }

    void InstanciaColetavel()
    {
        instanciar = false;
        Instantiate(coletavel, coordenadas[Sorteio()].position, Quaternion.identity);
    }

    private int Sorteio()
    {
        int sorteado = 0;
        bool livre = false;
        while (livre == false)
        {
            sorteado = Random.Range(0, 4);
            if (preenchidos[sorteado] == 0)
            {
                preenchidos[sorteado] = 1;
                Debug.Log(preenchidos[0] + "," + preenchidos[1] + "," + preenchidos[2] + "," + preenchidos[3]);
                livre = true;
            }
        }

        contaPreenchidos++;
        if (contaPreenchidos >= 4) ResetPreenchidos();
        return sorteado;


    }

    void ResetPreenchidos()
    {
        contaPreenchidos = 0;
        for (int i = 0; i <preenchidos.Length ; i++)
        {
            preenchidos[i] = 0;
        }
    }

    public void Pontuacao()
    {
        pontos++;
        textoPontos.text = pontos.ToString();
    }

}
