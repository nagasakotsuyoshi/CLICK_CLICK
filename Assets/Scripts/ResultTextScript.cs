using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextScript : MonoBehaviour
{
    public GameObject resultObject = null;
    // Start is called before the first frame update
    void Start()
    {
        Text resultText = resultObject.GetComponent<Text>();
        resultText.fontSize = 24;
        resultText.text = "結果：aaaaaaa\nスコア：";

    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("GameScene");
        }*/
    }
}
