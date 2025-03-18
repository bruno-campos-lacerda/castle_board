using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackChess : MonoBehaviour
{
    public bool canAttack;

    private TMP_Text scoreText;
    public int score;

    private void Start()
    {
        scoreText = GameObject.Find("Pontuação").GetComponent<TMP_Text>();
        canAttack = true;
    }
    private void Update()
    {
        if (!canAttack)
        {
            StartCoroutine(invensibilidade());
        }
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && canAttack)
        {
            Destroy(collision.gameObject);
            score++;
            canAttack = false;
        }
    }
    IEnumerator invensibilidade()
    {
        yield return new WaitForSeconds(2);
        canAttack = true;
    }
}
