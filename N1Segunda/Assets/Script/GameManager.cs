using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] public GameObject winUI;

    private void Update()
    {
        if (score == 45)
        {
            SceneManager.LoadScene("Vitoria");
            //winUI.SetActive(true);
        }
    }

    public void AddPoints(int value)
    {
        score = score + value; // || score += value || score = score + value
        Debug.Log("Você tem: " + score + " Pontos");
    }
}
