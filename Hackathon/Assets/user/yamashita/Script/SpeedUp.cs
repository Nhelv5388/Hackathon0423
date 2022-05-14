using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private Rigidbody2D rb;

    public float PlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.CompareTag("Player"))
		{
            StartCoroutine("speedUp");
			// 0.1秒後に消える
			Destroy(this.gameObject, 0.1f);
		}
	}

    IEnumerator speedUp()
    {
        yield return new WaitForSeconds(3.0f * Time.deltaTime);
        PlayerSpeed = PlayerSpeed * 2f;
    }

}
