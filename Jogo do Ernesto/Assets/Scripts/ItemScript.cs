using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour

{
    public Text scoreTxt;
    public int score;
    public bool passagem, trues;
    public int scorecomp;
    private int scoremax = 3;
    private GameObject currentTeleporter;
    public int level = 0;
    public int levelb0 = 0;
    public int  level2 = 1;
    public int level3 = 2;
    public int level4 = 3;
    private Vector3 RespawnPoint;
    public bool SetActive;
    /*public GameObject Ativos1, Ativos2, Ativos3, Ativos4, Ativos5, Ativos6, Ativos7, Ativos8, Ativos9, Ativos10, Ativos11, Ativos12, Ativos13;
    public GameObject Ativos14, Ativos15, Ativos16, Ativos17, Ativos18, Ativos19, Ativos20, Ativos21, Ativos22, Ativos23, Ativos24, Ativos25, Ativos26;
    public GameObject Ativos27, Ativos28, Ativos29, Ativos30, Ativos31, Ativos32, Ativos33, Ativos34, Ativos35, Ativos36, Ativos37, Ativos38;*/
    public GameObject[] ativos = new GameObject[38];
    //Os ativos são os coletáveis e os inimigos
    public GameObject Ernesto;
    public GameObject ernesto, ernesto1, ernesto2, ernesto3, ernesto4, ernesto5, ernesto6, ernesto7, ernesto8, ernesto9, ernesto10, ernesto11, ernesto12;
    public GameObject ernesto13, ernesto14, ernesto15, ernesto16, ernesto17, ernesto18, ernesto19, ernesto20, ernesto21, ernesto22, ernesto23, ernesto24, ernesto25;
    public GameObject ernesto26, ernesto27, ernesto28, ernesto29;
    public GameObject carneobj1, carneobj2, carneobj3;
    public GameObject[] cutscenes = new GameObject[30];
    public bool ImagemAuto = true;
    public Animator animator;
    int index = 0;

    private void Start()
    {
        scoremax = 3;
        score = 0;
        scorecomp = 3;
        trues = true;
        RespawnPoint = transform.position;
        Time.timeScale = 0f;
        
    }


    private void Update()
    {
        scoreTxt.text = score.ToString();
        if (score == scoremax)
        {
            passagem = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null && passagem == true && score == scoremax)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                level++;
                score = 0;
                Ernesto.GetComponent<MovimentoPlayer>().speed = 8f;
                if (level == level2)
                {
                  ativadorfase2();
                }
                if (level == level3)
                {
                  ativadorfase3();
                }
                if (level == level4)
                {
                  ativadorfase3final();
                }
                carneobj1.SetActive(false);
                carneobj2.SetActive(false);
                carneobj3.SetActive(false);
            }

        }
        if (ImagemAuto == true)
        {
          Time.timeScale = 0f;
        }
        

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

       if (col.CompareTag("Coletavel") == true)
        {
             score = score + 1;
             col.gameObject.SetActive(false);
             FindObjectOfType<AudioManager>().Play("PickupSound");
        
        }
        if (passagem == true && score == scoremax && col.CompareTag("Porta"))
        {
            print("porta pronta para uso");

        }

        if (col.CompareTag("Mortis") == true)
        {

            SceneManager.LoadScene("cena1");
        }

        if (col.CompareTag("Porta"))
        {
            currentTeleporter = col.gameObject;
        }
        if (col.CompareTag("StatusRemover") == true)
        {
            scoremax += 3;
        }
         if (col.CompareTag("CheckPoint") == true)
        {
            RespawnPoint = transform.position;
            
        }
        if (col.CompareTag("Colgamer") == true)
        {
            die();
                carneobj1.SetActive(false);
                carneobj2.SetActive(false);
                carneobj3.SetActive(false);
            
        }
        if (score == 1)
            {
                carneobj1.SetActive(true);
            } 
            if (score == 2)
            {
                carneobj2.SetActive(true);
            }
            if (score == 3)
            {
                carneobj3.SetActive(true);
            }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Porta"))
        {
            if (col.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
    void die()
    {
        transform.position = RespawnPoint;
         score = 0;
         Ernesto.GetComponent<MovimentoPlayer>().speed = 8f;
         Activate();
         /*Ativos1.SetActive(true);
         Ativos2.SetActive(true);
         Ativos3.SetActive(true);
         Ativos4.SetActive(true);
         Ativos5.SetActive(true);
         Ativos6.SetActive(true);
         Ativos7.SetActive(true);
         Ativos8.SetActive(true);
         Ativos9.SetActive(true);
         Ativos10.SetActive(true);
         Ativos11.SetActive(true);
         Ativos12.SetActive(true);
         Ativos14.SetActive(true);
         Ativos15.SetActive(true);
         Ativos16.SetActive(true);
         Ativos17.SetActive(true);
         Ativos18.SetActive(false);
         Ativos19.SetActive(false);
         Ativos20.SetActive(false);
         Ativos21.SetActive(false);
         Ativos22.SetActive(false);
         Ativos23.SetActive(false);
         Ativos24.SetActive(true);
         Ativos25.SetActive(true);
         Ativos26.SetActive(true);
         Ativos27.SetActive(true);
         Ativos28.SetActive(true);
         Ativos29.SetActive(true);
         Ativos30.SetActive(false);
         Ativos31.SetActive(false);
         Ativos32.SetActive(false);
         Ativos33.SetActive(true);
         Ativos34.SetActive(true);
         Ativos35.SetActive(true);
         Ativos36.SetActive(true);
         Ativos37.SetActive(true);
         Ativos38.SetActive(true);*/
    }
    void Activate() { 
        for(int i = 0; i < ativos.Length; i++)
        {
            switch (i){
                case int n when (n>=17 && n<=22 || n>=29 && n<=31):
                /*case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 29:
                case 30:
                case 31:*/
                    ativos[i].SetActive(false);
                    break;
                default:
                    ativos[i].SetActive(true); 
                    break;
                //Os cases que estão numerados são os das carnes
            }
            ativos[i].SetActive(true);
        }
    }
    
     public void TrocaCutScene()
    {
        if (index == 29) { 
            cutscenes[index].SetActive(false);
            cutscenes[0].SetActive(true);
            return;
        }
        cutscenes[index].SetActive(false);
        cutscenes[index +1].SetActive(true);
        index++;
    }
    public void ernestov ()
    {
    ernesto.SetActive(false);
    ernesto1.SetActive(true);
    }
    public void ernesto1v ()
    {
    ernesto1.SetActive(false);
    ernesto2.SetActive(true);
    }
    public void ernesto2v ()
    {
    ernesto2.SetActive(false);
    ernesto3.SetActive(true);
    }
    public void ernesto3v ()
    {
    ernesto3.SetActive(false);
    ernesto4.SetActive(true);
    }
    public void ernesto4v ()
    {
    ernesto4.SetActive(false);
    ernesto5.SetActive(true);
    }
    public void ernesto5v ()
    {
    ernesto5.SetActive(false);
    Time.timeScale = 1f;
    ImagemAuto = false;
    }
    public void ernesto6v ()
    {
    ernesto6.SetActive(false);
    Time.timeScale = 1f;
    ImagemAuto = false;
    }
    public void ernesto7v ()
    {
    ernesto7.SetActive(false);
    ernesto8.SetActive(true);
    }
    public void ernesto8v ()
    {
    ernesto8.SetActive(false);
    ernesto9.SetActive(true);
    }
    public void ernesto9v ()
    {
    ernesto9.SetActive(false);
    ernesto10.SetActive(true);
    }
    public void ernesto10v ()
    {
    ernesto10.SetActive(false);
    Time.timeScale = 1f;
    ImagemAuto = false;
    }
    public void ernesto11v ()
    {
    ernesto11.SetActive(false);
    ernesto12.SetActive(true);
    }
    public void ernesto12v ()
    {
    ernesto12.SetActive(false);
    ernesto13.SetActive(true);
    }
    public void ernesto13v ()
    {
    ernesto13.SetActive(false);
    ernesto14.SetActive(true);
    }
    public void ernesto14v ()
    {
    ernesto14.SetActive(false);
    ernesto15.SetActive(true);
    }
    public void ernesto15v ()
    {
    ernesto15.SetActive(false);
    ernesto16.SetActive(true);
    }
    public void ernesto16v ()
    {
    ernesto16.SetActive(false);
    ernesto17.SetActive(true);
    }
    public void ernesto17v ()
    {
    ernesto17.SetActive(false);
    ernesto18.SetActive(true);
    }
    public void ernesto18v ()
    {
    ernesto18.SetActive(false);
    ernesto19.SetActive(true);
    }
    public void ernesto19v ()
    {
    ernesto19.SetActive(false);
    ernesto20.SetActive(true);
    }
    public void ernesto20v ()
    {
    ernesto20.SetActive(false);
    ernesto21.SetActive(true);
    }
    public void ernesto21v ()
    {
    ernesto21.SetActive(false);
    ernesto22.SetActive(true);
    }
    public void ernesto22v ()
    {
    ernesto22.SetActive(false);
    ernesto23.SetActive(true);
    }
    public void ernesto23v ()
    {
    ernesto23.SetActive(false);
    ernesto24.SetActive(true);
    }
    public void ernesto24v ()
    {
    ernesto24.SetActive(false);
    ernesto25.SetActive(true);
    }
    public void ernesto25v ()
    {
    ernesto25.SetActive(false);
    ernesto26.SetActive(true);
    }
    public void ernesto26v ()
    {
    ernesto26.SetActive(false);
    ernesto27.SetActive(true);
    }
    public void ernesto27v ()
    {
    ernesto27.SetActive(false);
    ernesto28.SetActive(true);
    }
    public void ernesto28v ()
    {
    ernesto28.SetActive(false);
    SceneManager.LoadScene("cena0");
    Time.timeScale = 1f;
    ImagemAuto = false;
    }
    public void ernesto29v ()
    {
    ernesto29.SetActive(false);
    ernesto.SetActive(true);
    }
    public void ativadorfase2 ()
    {
    ernesto6.SetActive(true);
    Time.timeScale = 0f;
    ImagemAuto = true;
    }
    public void ativadorfase3 ()
    {
    ernesto7.SetActive(true);
    Time.timeScale = 0f;
    ImagemAuto = true;
    }
    public void ativadorfase3final ()
    {
    ernesto11.SetActive(true);
    Time.timeScale = 0f;
    ImagemAuto = true;
    }


}
