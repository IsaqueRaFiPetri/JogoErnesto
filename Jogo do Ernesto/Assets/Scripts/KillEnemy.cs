using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillEnemy : MonoBehaviour
{
    public GameObject bixo, bixo2, bixo3, bixo4, bixo5, bixo6, bixo7, bixo8, bixo9, bixo10, bixo11, bixo12, bixo13, bixo14, bixo15, bixo16, bixo17;
    public Collider2D colegal;
    public Animator animator;

    void Update()
    {
        
        
    }
      
  
        private void OnTriggerStay2D(Collider2D cole)
        {

        if (cole.CompareTag("Bixo") && Input.GetKey(KeyCode.F))
        {
            bixo.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();

        }
       
        if (cole.CompareTag("Bixo2") && Input.GetKey(KeyCode.F))
        {
            bixo2.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();

        }
        if (cole.CompareTag("Bixo3") && Input.GetKey(KeyCode.F))
        {
            bixo3.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo4") && Input.GetKey(KeyCode.F))
        {
            bixo4.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
         if (cole.CompareTag("Bixo5") && Input.GetKey(KeyCode.F))
        {
            bixo5.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
         if (cole.CompareTag("Bixo6") && Input.GetKey(KeyCode.F))
        {
            bixo6.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
         if (cole.CompareTag("Bixo7") && Input.GetKey(KeyCode.F))
        {
            bixo7.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
         if (cole.CompareTag("Bixo8") && Input.GetKey(KeyCode.F))
        {
            bixo8.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo9") && Input.GetKey(KeyCode.F))
        {
            bixo9.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo10") && Input.GetKey(KeyCode.F))
        {
            bixo10.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo11") && Input.GetKey(KeyCode.F))
        {
            bixo11.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo12") && Input.GetKey(KeyCode.F))
        {
            bixo12.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo13") && Input.GetKey(KeyCode.F))
        {
            bixo13.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo14") && Input.GetKey(KeyCode.F))
        {
            bixo14.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo15") && Input.GetKey(KeyCode.F))
        {
            bixo15.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo16") && Input.GetKey(KeyCode.F))
        {
            bixo16.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        if (cole.CompareTag("Bixo17") && Input.GetKey(KeyCode.F))
        {
            bixo17.SetActive(false);
            FindObjectOfType<AudioManager>().Play("AttackSound");
            Attack();
        }
        
        
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
    }
    //      private void OnTriggerEnter2D(Collider2D col)
    //  {
    //      if (col.CompareTag("Colgamer") == true)
    //      {
    //          
    //      }
    //
    //  }

}

