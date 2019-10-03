using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour
{
    public GameObject timeTextObj;

    private float remainingTime;
    private Text timeText;
    private const float START_TIME = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.timeText = this.timeTextObj.GetComponent<Text>();
        this.remainingTime = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.decrementTime();
        this.timeText.text = ((int)this.remainingTime).ToString();
    }

    public void decrementTime()
    {
        this.remainingTime = START_TIME - Time.time;
    }
}
