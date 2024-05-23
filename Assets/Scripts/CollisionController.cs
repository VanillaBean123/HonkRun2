using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class CollisionController : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int xcount = Random.Range(0, 3);

            if (xcount == 0)
            {
                SceneManager.LoadScene("TryAgainScene");
            }

            if (xcount == 1)
            {
                SceneManager.LoadScene("TryAgainScene2");
            }

            if (xcount == 2)
            {
                SceneManager.LoadScene("TryAgainScene3");
            }
        }
    }

}

