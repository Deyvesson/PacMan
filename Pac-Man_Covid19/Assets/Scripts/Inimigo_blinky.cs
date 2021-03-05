using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_blinky : MonoBehaviour
{
    // Start is called before the first frame updat
    // Update is called once per frame

    public float velocidadeInimigo;
    private bool direita = false;

    public Transform referenciaEsquerda;
    public Transform referenciaDireita;
    void Update()
    {
        if(direita){
            transform.position =  transform.position + new Vector3(velocidadeInimigo * Time.deltaTime, 0, 0);
        }else{
            transform.position =  transform.position - new Vector3(velocidadeInimigo * Time.deltaTime, 0, 0);
        }

        

        if(transform.position.x < referenciaEsquerda.position.x){
            direita = true; 
        }

        if(transform.position.x > referenciaDireita.position.x){
            direita = false; 
        }

    }
}
