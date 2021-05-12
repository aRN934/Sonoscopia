using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{

    [SerializeField]
    float duracao = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, duracao);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 30, 15) * Time.deltaTime);
    }

    private void OnDestroy()
    {
        GameObject.Find("cenario").GetComponent<Jogo>().instanciar = true;

    }
}
