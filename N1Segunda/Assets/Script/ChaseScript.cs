using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{
    public GameObject inimigo;
    public GameObject player;
    public float speed;
    void Start()
    {
        
    }

   
    void Update()
    {
        inimigo.transform.position = Vector3.MoveTowards(inimigo.transform.position, player.transform.position, speed);
    }
}
