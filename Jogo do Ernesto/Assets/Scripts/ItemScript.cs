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
    public GameObject Ativos, Ativos2, Ativos3, Ativos4, Ativos5, Ativos6, Ativos7, Ativos8, Ativos9, Ativos10, Ativos11, Ativos12, Ativos13;
    public GameObject Ativos14, Ativos15, Ativos16, Ativos17, Ativos18, Ativos19, Ativos20, Ativos21, Ativos22, Ativos23, Ativos24, Ativos25, Ativos26;
    public GameObject Ativos27, Ativos28, Ativos29, Ativos30, Ativos31, Ativos32, Ativos33, Ativos34, Ativos35, Ativos36, Ativos37, Ativos38;
    public GameObject Ernesto;
    public GameObject CutCine, CutCine1, CutCine2, CutCine3, CutCine4, CutCine5, CutCine6, CutCine7, CutCine8, CutCine9, CutCine10, CutCine11, CutCine12;
    public GameObject CutCine13, CutCine14, CutCine15, CutCine16, CutCine17, CutCine18, CutCine19, CutCine20, CutCine21, CutCine22, CutCine23, CutCine24, CutCine25;
    public GameObject CutCine26, CutCine27, CutCine28, CutCine29;
    public GameObject carneobj1, carneobj2, carneobj3;
    public bool ImagemAuto = true;
    public Animator animator;

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
                CutCine.GetComponent<MovimentoPlayer>().speed = 8f;
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
         CutCine.GetComponent<MovimentoPlayer>().speed = 8f;
         Ativos.SetActive(true);
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
         Ativos38.SetActive(true);
    }
      public void CutCinev ()
      {
        CutCine.SetActive(false);
        CutCine1.SetActive(true);
      }
      public void CutCine1v ()
      {
        CutCine1.SetActive(false);
        CutCine2.SetActive(true);
      }
      public void CutCine2v ()
      {
        CutCine2.SetActive(false);
        CutCine3.SetActive(true);
      }
      public void CutCine3v ()
      {
        CutCine3.SetActive(false);
        CutCine4.SetActive(true);
      }
      public void CutCine4v ()
      {
        CutCine4.SetActive(false);
        CutCine5.SetActive(true);
      }
      public void CutCine5v ()
      {
        CutCine5.SetActive(false);
        Time.timeScale = 1f;
        ImagemAuto = false;
      }
      public void CutCine6v ()
      {
        CutCine6.SetActive(false);
        Time.timeScale = 1f;
        ImagemAuto = false;
      }
      public void CutCine7v ()
      {
        CutCine7.SetActive(false);
        CutCine8.SetActive(true);
      }
      public void CutCine8v ()
      {
        CutCine8.SetActive(false);
        CutCine9.SetActive(true);
      }
      public void CutCine9v ()
      {
        CutCine9.SetActive(false);
        CutCine10.SetActive(true);
      }
      public void CutCine10v ()
      {
        CutCine10.SetActive(false);
        Time.timeScale = 1f;
        ImagemAuto = false;
      }
      public void CutCine11v ()
      {
        CutCine11.SetActive(false);
        CutCine12.SetActive(true);
      }
      public void CutCine12v ()
      {
        CutCine12.SetActive(false);
        CutCine13.SetActive(true);
      }
      public void CutCine13v ()
      {
        CutCine13.SetActive(false);
        CutCine14.SetActive(true);
      }
      public void CutCine14v ()
      {
        CutCine14.SetActive(false);
        CutCine15.SetActive(true);
      }
      public void CutCine15v ()
      {
        CutCine15.SetActive(false);
        CutCine16.SetActive(true);
      }
      public void CutCine16v ()
      {
        CutCine16.SetActive(false);
        CutCine17.SetActive(true);
      }
      public void CutCine17v ()
      {
        CutCine17.SetActive(false);
        CutCine18.SetActive(true);
      }
      public void CutCine18v ()
      {
        CutCine18.SetActive(false);
        CutCine19.SetActive(true);
      }
      public void CutCine19v ()
      {
        CutCine19.SetActive(false);
        CutCine20.SetActive(true);
      }
      public void CutCine20v ()
      {
        CutCine20.SetActive(false);
        CutCine21.SetActive(true);
      }
      public void CutCine21v ()
      {
        CutCine21.SetActive(false);
        CutCine22.SetActive(true);
      }
      public void CutCine22v ()
      {
        CutCine22.SetActive(false);
        CutCine23.SetActive(true);
      }
      public void CutCine23v ()
      {
        CutCine23.SetActive(false);
        CutCine24.SetActive(true);
      }
      public void CutCine24v ()
      {
        CutCine24.SetActive(false);
        CutCine25.SetActive(true);
      }
      public void CutCine25v ()
      {
        CutCine25.SetActive(false);
        CutCine26.SetActive(true);
      }
      public void CutCine26v ()
      {
        CutCine26.SetActive(false);
        CutCine27.SetActive(true);
      }
      public void CutCine27v ()
      {
        CutCine27.SetActive(false);
        CutCine28.SetActive(true);
      }
      public void CutCine28v ()
      {
        CutCine28.SetActive(false);
        SceneManager.LoadScene("cena0");
        Time.timeScale = 1f;
        ImagemAuto = false;
      }
      public void CutCine29v ()
      {
        CutCine29.SetActive(false);
        CutCine.SetActive(true);
      }
      public void ativadorfase2 ()
      {
        CutCine6.SetActive(true);
        Time.timeScale = 0f;
        ImagemAuto = true;
      }
      public void ativadorfase3 ()
      {
        CutCine7.SetActive(true);
        Time.timeScale = 0f;
        ImagemAuto = true;
      }
      public void ativadorfase3final ()
      {
        CutCine11.SetActive(true);
        Time.timeScale = 0f;
        ImagemAuto = true;
      }


}