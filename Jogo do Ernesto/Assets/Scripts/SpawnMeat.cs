using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeat : MonoBehaviour
{
    public GameObject carne;

    // Update is called once per frame
    public void OnDisable()
    {
        carne.SetActive(true);
    }
}
