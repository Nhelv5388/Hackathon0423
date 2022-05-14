using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{

    [SerializeField]private float speed;
    [SerializeField]private float startPos;
    [SerializeField]private float endPos;
    private Vector2 pos;
    private bool isStop = false;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (!isStop)
        {
            pos.x += Time.deltaTime * speed; // speedは移動速度
            transform.position = pos;

            if (pos.x > endPos) // 終点（自由に変更可能）
            {
                isStop = true;
            }
        }
        else
        {
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;

            if (pos.x < startPos) // 始点（自由に変更可能）
            {
                isStop = false;
            }
        }
    }
}