using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Timer : MonoBehaviour
{
    public float timer;

    private bool isWaving;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isWaving = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        if (timer < 0)
        {
            isWaving = true;
            RunAnimations();
        }
    }

    void RunAnimations()
    {
        anim.SetBool("isWaving", isWaving); //calls the isJumping animation.
    }
}
