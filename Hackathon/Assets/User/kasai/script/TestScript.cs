using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField] private GameObject PlayerObject;    //�v���C���[�I�u�W�F�N�g
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
            //�ʔ���1
        }
        else
        {
            //�ʔ���2
        }

        IEnumerator bullet1()
        {
            //�ʂ𐶐�����(��)   
            yield return null;
        }

        IEnumerator bullet2()
        {   
            //�ʂ𐶐�����(�E)
            yield return null;
        }
    }
}
