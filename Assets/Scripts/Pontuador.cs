using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuador : MonoBehaviour
{
    public TextMesh scoreText;
    public int score;

    public static Pontuador Instance;

    void Start()
    {
        Instance = this;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
