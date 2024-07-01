using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavour : MonoBehaviour
{
    [SerializeField] float rotSpeed;
    [SerializeField] float size;
    [SerializeField] float speed;
    Rigidbody2D rb2D;
    HealthManager hM;
    GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        rotSpeed = Random.Range(-200f, 200f);
        speed = Random.Range(1f, 10f);
        size = Random.Range(0.25f, 2f);

        

        gameObject.transform.localScale += new Vector3(size, size, 0);
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(GO());
    }

    IEnumerator GO()
    {
        yield return new WaitForSeconds(1.5f);

        rb2D.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D()
    {
        player = GameObject.Find("Player");
        hM = player.gameObject.GetComponent<HealthManager>();
        hM.Damage();
        Debug.Log("Crash");
        GameObject.Destroy(gameObject);
    }
}
