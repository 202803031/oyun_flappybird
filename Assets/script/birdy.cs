using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdy : MonoBehaviour
{

    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public gamemanager managergame;

    public GameObject DeathScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    {

        // t�klamay� al
        if (Input.GetMouseButtonDown(0))
        {

            // havada ku�u z�plat
            rb2D.velocity = Vector2.up * velocity;


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "skorb�lgesi")
        {

            managergame.uptadescore();

        }

}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadarea")
        {
            isDead = true;
            Time.timeScale = 0;


            DeathScreen.SetActive(true);
        }



    }







}
