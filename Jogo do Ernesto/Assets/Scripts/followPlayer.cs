using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;


    private void Update()
    {
        Vector3 playerX = new Vector3(player.position.x,transform.position.y, transform.position.z);
        transform.position = playerX;
    }
}
