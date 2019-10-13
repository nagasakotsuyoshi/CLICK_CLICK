using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum GameState
{
    READY,
    PLAY
}

public class GameManagerScript : MonoBehaviour
{
    public GameObject timeTextObj;
    public GameObject buttonTextObj;
    public GameObject clickButtonObj;

    private GameState state = GameState.READY;
    private float remainingReadyTime;
    private float remainingPlayTime;

    private Text timeText;
    private Text buttonText;
    private Button clickButton;

    private const float READY_TIME = 5.0f;
    private const float PLAY_TIME = 15.0f;
    private const string READY_TEXT = "READY";
    private const string START_TEXT = "クリックせよ！";

    // Start is called before the first frame update
    void Start()
    {
        this.buttonText = this.buttonTextObj.GetComponent<Text>();
        this.timeText = this.timeTextObj.GetComponent<Text>();
        this.clickButton = this.clickButtonObj.GetComponent<Button>();
        this.remainingReadyTime = READY_TIME;
        this.remainingPlayTime = PLAY_TIME;
        this.clickButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (this.state)
        {
            case GameState.READY:
                if (this.remainingReadyTime <= 0)
                {
                    this.state = GameState.PLAY;
                    this.buttonText.text = START_TEXT;
                    this.clickButton.interactable = true;
                    break;
                }
                this.decrementReadyTime();
                this.buttonText.text =
                    READY_TEXT + ":" + ((int)this.remainingReadyTime).ToString();
                break;
            case GameState.PLAY:
                if (this.remainingPlayTime <= 0)
                {
                    // リザルトシーンに切り替え
                }
                this.decrementPlayTime();
                this.timeText.text = ((int)this.remainingPlayTime).ToString();
                break;
            default:
                break;
        }
    }

    public void decrementReadyTime()
    {
        this.remainingReadyTime = READY_TIME - Time.time;
    }

    public void decrementPlayTime()
    {
        this.remainingPlayTime = PLAY_TIME + READY_TIME - Time.time;
    }
}
