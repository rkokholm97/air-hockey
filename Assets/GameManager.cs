using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float countDownDuration;
    private float countdownTime;
    private bool timerOn = false;
    
    public GameObject puck;
    private GameObject currentPuck;
    public TextMeshProUGUI countdownText;

    public TextMeshProUGUI playerOnePointsText;
    public TextMeshProUGUI playerTwoPointsText;

    // Start is called before the first frame update
    void Start()
    {
        startCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn) {
            if(countdownTime > 0) {
                countdownTime -= Time.deltaTime;
                updateTimer();
            } else {
                countdownText.text = "";
                timerOn = false;
                startGame();  
            }
        }

        // Check if puck is colliding with a goal
        

    }

    void updateTimer() {
        countdownText.text = Mathf.FloorToInt(countdownTime).ToString();
    }

    void resetTimer() {
        countdownTime = countDownDuration;
    }

    void startCountdown() {
        resetTimer();
        timerOn = true;
    }

    void startGame() {
        spawnPuck();
        // Reset points
        // Spawn puck
    }

    void spawnPuck(){
        currentPuck = Instantiate(puck, new Vector3(0,0,0), Quaternion.identity);
    }
}
