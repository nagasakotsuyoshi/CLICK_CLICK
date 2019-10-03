using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResultButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
