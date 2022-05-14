using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField] private GameObject PlayerObject;    //プレイヤーオブジェクト
    [SerializeField] private GameObject leftmuzzle;
    [SerializeField] private GameObject rightmuzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerObject.transform.position.x<this.transform.postion.x)
        {
            //玉発射1
        }
        else
        {
            //玉発射2
        }

        IEnumerator bullet1()
        {
            //玉を生成する(左)   
            yield return null;
        }

        IEnumerator bullet2()
        {   
            //玉を生成する(右)
            yield return null;
        }
    }
}
