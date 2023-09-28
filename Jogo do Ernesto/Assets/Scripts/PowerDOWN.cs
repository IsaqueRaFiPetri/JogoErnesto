using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDOWN : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject collec;
    
    void OnTriggerEnter2D(Collider2D col)
    {
       Objeto.GetComponent<MovimentoPlayer>().speed = 6.5f;
       collec.SetActive(false);
       FindObjectOfType<AudioManager>().Play("PickupSound");
    }

}