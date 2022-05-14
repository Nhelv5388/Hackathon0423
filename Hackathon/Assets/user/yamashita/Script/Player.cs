using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed = 3.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-PlayerSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(PlayerSpeed, rb.velocity.y);
        }
        // キーを離すと止まる
        else
        {
            rb.velocity = Vector2.zero;
        }
        
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Gimmick")
        {
            StartCoroutine("SpeedUp");
        }
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(3.0f * Time.deltaTime);
        PlayerSpeed = PlayerSpeed * 2f;
    }
    

}
