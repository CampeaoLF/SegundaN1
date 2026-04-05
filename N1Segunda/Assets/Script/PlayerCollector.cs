using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollector : MonoBehaviour
{
    [SerializeField] public GameManager gameManager;
    public GameObject player;
    public GameObject defeatUI;
    public CanvaManager canvaManager;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("alface"))
        {
            CollectItem collectible = other.GetComponent<CollectItem>();

            if (collectible != null)
            {
                gameManager.AddPoints(collectible.points);
                Destroy(other.gameObject);
                canvaManager.alfaceCount++;
            }

            
        }

        if (other.CompareTag("coin"))
        {
            CollectItem collectible = other.GetComponent<CollectItem>();

            if (collectible != null)
            {
                gameManager.AddPoints(collectible.points);
                Destroy(other.gameObject);
                canvaManager.coinCount++;
            }


        }

        if (other.CompareTag("diamond"))
        {
            CollectItem collectible = other.GetComponent<CollectItem>();

            if (collectible != null)
            {
                gameManager.AddPoints(collectible.points);
                Destroy(other.gameObject);
                canvaManager.diamondCount++;
            }


        }

        if (other.CompareTag("Enemy"))
        {
            Destroy(player);

            SceneManager.LoadScene("Derrota");
            
            //defeatUI.SetActive(true);
        }

        
    }
}
