using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    // Star is called before the first frame update
    Rigidbody2D Rb;          // inisialisasi Rigidbody
    public float jumpForce;  // besar loncatan
    float score;

    public Text scoreTxt;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();  // ambil komponen Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;
        if (Input.GetMouseButtonDown(0))  // klik kiri (PC) / tap (HP)
        {
            Rb.velocity = Vector2.up * jumpForce;  // naik dengan kecepatan jumpForce
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Poin")
        {
            score++;
            Debug.Log("Score: " + score);
        }

        if(collision.gameObject.tag =="pipa")
        {
            Destroy(gameObject);
        }

    }
}