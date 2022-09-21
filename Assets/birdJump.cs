using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdJump : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    public float jumpPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(score.Score > score.bestScore)
        {
            score.bestScore = score.Score;
        }
        SceneManager.LoadScene("gameoverScene");
    }
}
