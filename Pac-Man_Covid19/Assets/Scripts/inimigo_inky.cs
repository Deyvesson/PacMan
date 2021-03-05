using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo_inky : MonoBehaviour
{
    public float velocidadeInimigo;
    private bool Cima = false;

    public Transform referenciaCima;
    public Transform referenciaBaixo;
    void Update()
    {
        if(Cima){
            transform.position =  transform.position + new Vector3(0, velocidadeInimigo * Time.deltaTime, 0);
        }else{
            transform.position =  transform.position - new Vector3(0, velocidadeInimigo * Time.deltaTime, 0);
        }

        

        if(transform.position.y > referenciaCima.position.y){
            Cima = false; 
        }

        if(transform.position.y < referenciaBaixo.position.y){
            Cima = true; 
        }

    }
}
