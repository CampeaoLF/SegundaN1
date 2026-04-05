using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    [SerializeField] public float rotateSpeed = 120f;

    private float horizontal;
    private float vertical;

    void Update()
    {
        GetInput();
        Move();
    }

    private void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        // Movimento pra frente e trás baseado na rotação do player
        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Rotação suave
        float rotation = horizontal * rotateSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
}
