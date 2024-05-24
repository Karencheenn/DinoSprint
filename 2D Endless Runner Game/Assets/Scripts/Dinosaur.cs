using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
    bool isJumping;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false) {
            rb.velocity = new Vector2(0, jump);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isJumping = false;

        if (collision.gameObject.tag == "Cactus") {
            gm.GameOver();
        }

    }
}
//hello