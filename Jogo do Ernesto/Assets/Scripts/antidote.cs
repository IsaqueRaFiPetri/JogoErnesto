using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antidote : MonoBehaviour
{
   public GameObject Objeto;
    public GameObject collec;

    void OnTriggerEnter2D(Collider2D col)
    {
        Objeto.GetComponent<MovimentoPlayer>().speed = 8f;
        collec.SetActive(false);
        FindObjectOfType<AudioManager>().Play("PickupSound");
    }

}
