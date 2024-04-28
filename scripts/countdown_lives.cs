using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown_lives : MonoBehaviour
{
    public Text count_Timer;
    public float TimeRemaining = 10f;
    public bool startBool;
    


    // Start is called before the first frame update
    void Start()
    {
        startBool = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startBool)
        {
            StartTimer();
        }
        
    }

    public void StartTimer()
    {
        
        count_Timer = GetComponent<Text>();
        TimeRemaining -= Time.unscaledDeltaTime;
        count_Timer.text = TimeRemaining.ToString("0");
        if (TimeRemaining < 1)
        {
            Frog_Move.frogLives += 3;            
            startBool = false;
            SceneManager.LoadScene(Frog_Move.level);
        }        
    }

    
}

