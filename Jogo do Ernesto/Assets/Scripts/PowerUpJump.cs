using System.Collections;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    //S� coloque isso em um objeto e t� pronto, qualquer duvida, Nicolas
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(PowerUpCollet(collision.gameObject));
        }
    }

    private IEnumerator PowerUpCollet(GameObject player)
    {

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        //player.GetComponent<move>().speed = 12.0f;
        player.GetComponent<MovimentoPlayer>().jumpingPower = 25.0f;

        yield return new WaitForSeconds(5.0f);

        player.GetComponent<MovimentoPlayer>().jumpingPower = 20.0f;

        Destroy(gameObject);
    }

}