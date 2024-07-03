using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    float waitTime;

    [SerializeField] bool godMode = false;

    #region type

    [SerializeField] GameObject regular;
    [SerializeField] GameObject splitter;
    [SerializeField] GameObject explosive;
    [SerializeField] GameObject shooting;
    [SerializeField] GameObject alive;
    [SerializeField] GameObject oblong;
    [SerializeField] GameObject mine;

    #endregion

    private void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }



    public IEnumerator SpawnAsteroid()
    {
        if (!godMode)
        {

            waitTime = Random.Range(2.5f, 6.5f);
            int type;


            GameObject asteroid = regular;

            float coinToss;
            coinToss = Random.Range(0f, 2f);
            if (coinToss > 1f)
            {
                asteroid = regular;
            }

            if (coinToss < 1f)
            {

                type = Random.Range(1, 6);
                if (type == 1)
                {
                    asteroid = explosive;
                }

                if (type == 2)
                {
                    asteroid = splitter;
                }

                if (type == 3)
                {
                    asteroid = mine;
                }

                if (type == 4)
                {
                    asteroid = shooting;
                }
                if (type == 5)
                {
                    asteroid = alive;
                }

            }





            yield return new WaitForSeconds(waitTime);

            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(asteroid, randomPositionOnScreen, Quaternion.identity);

            StartCoroutine(SpawnAsteroid());
        }

        else
        {
            Debug.Log("Spawned asteroid");
        }
    }

    private void Update()
    {
        if (godMode)
        {
            SpawnPower();
        }
    }
    void SpawnPower()
    {
        if (Input.GetKeyDown("1"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(regular, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("2"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(splitter, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("3"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(explosive, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("4"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(shooting, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("5"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(alive, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("6"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(oblong, randomPositionOnScreen, Quaternion.identity);
        }

        if (Input.GetKeyDown("7"))
        {
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(mine, randomPositionOnScreen, Quaternion.identity);
        }
    }
}
