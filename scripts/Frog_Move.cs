using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Frog_Move : MonoBehaviour
{
    public static bool gameFreeze;
    public static int level = 1;

    public static int frogLives = 5;

    public float MoveSpeed = 1; // sets move speed to 1
    bool faceRight = true;
    //public int levelNumber = level;

    public float jump = 1; // sets jump height to 1
    private bool isJumping;
    private Animator anim;
       

    private Rigidbody2D rb;
   
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        SavePlayerPos();
        rb = GetComponent<Rigidbody2D>();        
        anim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        

        float movement = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * MoveSpeed, rb.velocity.y); //moves the charactor

        if(movement<0 && faceRight)
        {
            flip();
        }
        else if (movement>0 && !faceRight)
        {
            flip();
        }

        if (CrossPlatformInputManager.GetButtonDown("Jump") && !isJumping)// if spaceBar pressed, causes charactor to jump.
        {
            Frog_Sound.PlayCroak();
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
            
         }
        RunAnimations();

        

    }

    

    private void OnCollisionEnter2D(Collision2D collision) //collision detection for frog to not jump animate when on ground tag.
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void SetFrogLives(int number)
    {
        frogLives = number;
    }

    public void FiveLives()
    {
        frogLives += 5;
    }

    public int GetFrogLives()
    {
        return frogLives;
    }

    public void IncreaseLives()
    {
        frogLives += 2;
    }

    public void HeartOne()
    {
        frogLives += 1;
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void IncrementLevel()
    {
        level += 1;
    }

    public int getLevel()
    {
        return level;
    }
    public void SavePlayerPos()
    {
        save_Game.saveLevel(this);
    }


    void Jump()
    {
        rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        isJumping = true;
    }

    void RunAnimations()
    {
        anim.SetBool("isJumping", isJumping); //calls the isJumping animation.
    }

    

}
