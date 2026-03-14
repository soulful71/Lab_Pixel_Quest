using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GeoController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    string jaroobed = "bankai";
    int counter = 1;
    public float Speed;
    public string NextLevel = "Level2";
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("hasdasd");
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontalInput * Speed  , rb.velocity.y);
        /*
        Debug.Log(counter);
        counter++;
        if (Input.GetKeyDown(KeyCode.W)) ;
        transform.position += new Vector3(0, 1, 0);
        */
        if (Input.GetKey(KeyCode.Alpha1))
        {
        
            sr.color = Color.black;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            sr.color = Color.red;
        }

      

        if (Input.GetKey(KeyCode.Alpha3))
        {
            sr.color = Color.cyan;
        }
        ;
       
       
    }
       
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        switch (collision.gameObject.tag)
        {
            case "Death":
                {
                    string levelName = SceneManager.GetActiveScene().name;
                    Debug.Log("player has reahed death");
                    SceneManager.LoadScene(levelName);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(NextLevel);
                    break;
                }
        }
    }
         


} 
    
          