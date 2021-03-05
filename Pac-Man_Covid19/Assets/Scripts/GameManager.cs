using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int pontuacaoAtual = 0;
    public GameObject btnStart;
    void Start()
    {
       Time.timeScale = 0; 
    }

    // Update is called once per frame
    public void ComecarJogo(){
        Time.timeScale = 1;
        btnStart.SetActive(false);
    }

    public void TerminarJogo(){
        btnStart.SetActive(true);
        SceneManager.LoadScene(0);
    }

}
