using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ntitodo : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject collec;

    void OnTriggerEnter2D(Collider2D col)
    {
        Objeto.GetComponent<MovimentoPlayer>().speed = 8f;
        Objeto.GetComponent<MovimentoPlayer>().jumpingPower = 9.5f;
        collec.SetActive(false);
    }

}