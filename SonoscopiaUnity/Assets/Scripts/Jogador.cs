﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("SoundTrigger"))
        {
            Debug.Log("entrei na zona");
            other.GetComponent<AudioSource>().Play();
        }
        if(other.CompareTag("Coletavel"))
        {
            other.transform.parent.gameObject.SetActive(false);
            GameObject.Find("cenario").GetComponent<Jogo>().Pontuacao();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SoundTrigger"))
        {
            other.GetComponent<AudioSource>().Stop();
        }
    }
}
