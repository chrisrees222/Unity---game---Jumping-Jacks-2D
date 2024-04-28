using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)//if the frog collides with the tagged platform, increases score by 1.
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
