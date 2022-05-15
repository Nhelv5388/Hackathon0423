using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("Accel", 3);
    }

    void Accel()
    {
        // 参照するスクリプト
        PlayerMove playerMove;
        // Playerというオブジェクトを探す
        GameObject Player = GameObject.Find("Player");
        // Playerに付いているスクリプトを取得
        playerMove = Player.GetComponent<PlayerMove>();
        // PlayerSpeedを変える
        playerMove.PlayerSpeed = playerMove.PlayerSpeed * 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (other.CompareTag("Player"))
        {
            Accel();
            // 0.1秒後に消える
            Destroy(this.gameObject, 0.1f);
        }
    }

}
