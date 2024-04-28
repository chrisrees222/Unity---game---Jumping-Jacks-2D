using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public bool moveUp;
    private float upSpeed;

    
    private void Start()
    {
        moveUp = true;        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp && Frog_Move.level == 1)
        {
            upSpeed = 0.2f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if(moveUp && Frog_Move.level == 2)
        {
            upSpeed = 0.3f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 3)
        {
            upSpeed = 0.4f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 4)
        {
            upSpeed = 0.5f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 5)
        {
            upSpeed = 0.6f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 5)
        {
            upSpeed = 0.7f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 6)
        {
            upSpeed = 0.8f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 7)
        {
            upSpeed = 0.9f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 8)
        {
            upSpeed = 0.9f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level == 9)
        {
            upSpeed = 1.0f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level >= 10 && moveUp && Frog_Move.level < 14)
        {
            upSpeed = 1.0f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level >= 14 && moveUp && Frog_Move.level <= 20)
        {
            upSpeed = 1.1f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }
        else if (moveUp && Frog_Move.level >= 21 && moveUp && Frog_Move.level <= 30)
        {
            upSpeed = 1.2f;
            transform.Translate(0, upSpeed * Time.deltaTime, 0);
        }

    }

    

    public float SetUpSpeed(float newSpeed)
    {
        return upSpeed = newSpeed;
    }

    public void FreezeCamera()
    {
        moveUp = false;        
    }

    public void ResumeCamera()
    {
        moveUp = true;
    }


}
