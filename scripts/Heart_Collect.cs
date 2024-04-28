using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Collect : MonoBehaviour
{
    public Frog_Move frog;

    void OnCollisionEnter2D(Collision2D collision)//if the frog collides with the heart, destroys the object.
    {
        if (collision.gameObject.tag == "Player")
        {
            frog.HeartOne();
            frog.SavePlayerPos();
            Destroy(gameObject);
        }
    }
}
