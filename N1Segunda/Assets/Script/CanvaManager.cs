using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CanvaManager : MonoBehaviour
{
    public GameManager gameManager;
    public CollectItem[] pointValue;
    public TextMeshProUGUI scoreGeral;
    public TextMeshProUGUI diamondUI;
    public TextMeshProUGUI coinUI;
    public TextMeshProUGUI alfaceUI;
    public GameObject winUI;
    public GameObject[] teste;
    public int alfaceCount = 0;
    public int coinCount = 0;
    public int diamondCount = 0;
    //listas e valores internos??


    private void Start()
    {
        winUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (scoreGeral)
        {
            scoreGeral.text = "Score : " + gameManager.score.ToString();
        }

        if (alfaceUI)
        {
            alfaceUI.text = alfaceCount.ToString();
        }

        if (coinUI)
        {
            coinUI.text = coinCount.ToString();
        }

        if (diamondUI)
        {
            diamondUI.text = diamondCount.ToString();
        }

        if (gameManager.score == 45)
        {
            winUI.SetActive(true);
        }

       //if (pointValue[8].points == 5)
       //{
       //     diamondUI.text = "1";
       //}

    }
}
