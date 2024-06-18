using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bullet;
    Vector3 playerRot;
    Vector3 playerPos;

    private void Start()
    {
        player = gameObject;
    }

    void Update()
    {
        playerPos = transform.position;
        playerRot = new Vector3(0f, 0f, transform.rotation.z);
        //playerRot = transform.rotation;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        void Shoot()
        {
            Instantiate(bullet, playerPos, Quaternion.identity);
            Debug.Log("BANG!");
        }
    }
}
