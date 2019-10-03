using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResultButtonScript : MonoBehaviour
{
    public GameObject resultObject = null;

    void Start()
    {
        Text resultText = resultObject.GetComponent<Text>();
        resultText.fontSize = 24;
        resultText.text = "もう一回！";

    }
    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
