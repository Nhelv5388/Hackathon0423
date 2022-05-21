using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Start is called before the first frame update
    private float startSpeed;
    void Start()
    {
        // 参照するスクリプト
        PlayerMove playerMove;
        // Playerというオブジェクトを探す
        GameObject Player = GameObject.Find("Player");
        // Playerに付いているスクリプトを取得
        playerMove = Player.GetComponent<PlayerMove>();
        startSpeed = playerMove.PlayerSpeed;
    }

    void Update()
    {

    }

    void Accel()
    {
        // 参照するスクリプト
        PlayerMove playerMove;
        // Playerというオブジェクトを探す
        GameObject Player = GameObject.Find("Player");
        // Playerに付いているスクリプトを取得
        playerMove = Player.GetComponent<PlayerMove>();
        // 加速
        playerMove.PlayerSpeed = playerMove.PlayerSpeed * 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (other.CompareTag("Player"))
        {
            Accel();
            Invoke("SpeedReset", 3.0f);
            // 0.1秒後に消える
            Destroy(this.gameObject, 0.1f);
        }
    }

    void SpeedReset()
    {
        PlayerMove playerMove;
        GameObject Player = GameObject.Find("Player");
        playerMove = Player.GetComponent<PlayerMove>();
        playerMove.PlayerSpeed = playerMove.PlayerSpeed / 2.0f;
    }
}
