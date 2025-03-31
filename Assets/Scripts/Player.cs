using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10;
    // Update is called once per frame
    public Rigidbody2D rb;
    
    public string currColor;
    public Follow camFollow;

    public SpriteRenderer sr;
    public string but;
    public Color pink;
    public Color cyan;
    public Color magenta;
    public Color yellow;
    public Vector3 lastCheckpoint;
    public GameObject finishPanel;
    void Start()
    {
        SetRandomColor();
        lastCheckpoint = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(but))
        {
            rb.gravityScale = 3;
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Check")
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0;

            transform.position = new Vector3(transform.position.x, -3.75f, transform.position.y);
        }

        if (col.tag != currColor && col.tag != "Check" && col.tag != "ColorChanger" && col.tag != "Finish")
        {
            Respawn();
        }

        if (col.tag == "Finish")
        {
            if (finishPanel != null)
            {
                finishPanel.SetActive(true); // Activate the panel
                camFollow.CamPosFinish();
                Stop();
            }
            else
            {
                Debug.LogError("Finish Panel is not assigned in the Player script!");
            }
        }

        if (col.tag == "ColorChanger")
        {
            SpriteRenderer sr2 = col.gameObject.GetComponent<SpriteRenderer>();
            sr.color = sr2.color;
            Destroy(col.gameObject);
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currColor = "Cyan";
                sr.color = cyan;
                break;
            case 1:
                currColor = "Magenta";
                sr.color = magenta;
                break;
            case 2:
                currColor = "Pink";
                sr.color = pink;
                break;
            case 3:
                currColor = "Yellow";
                sr.color = yellow;
                break;
        }
    }

    void Respawn()
    {
        transform.position = lastCheckpoint;
        rb.velocity = Vector2.zero;
        rb.gravityScale = 3;
        SetRandomColor();

        if (camFollow != null)
        {
            camFollow.CamPosBack(); // Reset camera position
        }
        else
        {
            Debug.LogError("Follow script is not assigned in the Player script!");
        }
    }
    void Stop()
    {
        rb.velocity = Vector2.zero;
        rb.gravityScale = 0;
    }
}


    
    