using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{

    [SerializeField] public int points = 1;
    [SerializeField] public float rotationSpeed = 100f;
    [SerializeField] public float objectHeight = 1.5f;
  



    void Update()
    {
        RotateObject();
      
       
    }
    
    void RotateObject()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        
    }

    
}
