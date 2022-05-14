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
            pos.x += Time.deltaTime * speed; // speed�͈ړ����x
            transform.position = pos;

            if (pos.x > endPos) // �I�_�i���R�ɕύX�\�j
            {
                isStop = true;
            }
        }
        else
        {
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;

            if (pos.x < startPos) // �n�_�i���R�ɕύX�\�j
            {
                isStop = false;
            }
        }
    }
}