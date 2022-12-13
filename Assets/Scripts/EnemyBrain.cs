using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    private bool dead = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Run(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dead = true;
        }


    }

    public void Run(GameObject player)
    {
        if (!dead)
        {
            Vector2 direction = gameObject.transform.position - player.transform.position;
            transform.Translate(direction.normalized * 0.1f * Time.deltaTime);
        }

    }
}
