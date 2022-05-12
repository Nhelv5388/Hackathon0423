using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    public static bool isFadeInstance = false;

    public bool isFadeIn = false;//�t�F�[�h�C������t���O
    public bool isFadeOut = false;//�t�F�[�h�A�E�g����t���O

    public float alpha = 0.0f;//���ߗ��A�����ω�������
    public float fadeSpeed = 0.2f;//�t�F�[�h�Ɋ|���鎞��

    void Start()
    {
        //�ȗ�
    }

    void Update()
    {
        if (isFadeIn)
        {
            alpha -= Time.deltaTime / fadeSpeed;
            if (alpha <= 0.0f)//�����ɂȂ�����A�t�F�[�h�C�����I��
            {
                isFadeIn = false;
                alpha = 0.0f;
            }
            this.GetComponentInChildren<Image>().color = new Color(0.0f, 0.0f, 0.0f, alpha);
        }
        else if (isFadeOut)
        {
            alpha += Time.deltaTime / fadeSpeed;
            if (alpha >= 1.0f)//�^�����ɂȂ�����A�t�F�[�h�A�E�g���I��
            {
                isFadeOut = false;
                alpha = 1.0f;
            }
            this.GetComponentInChildren<Image>().color = new Color(0.0f, 0.0f, 0.0f, alpha);
        }
    }

    public void fadeIn()
    {
        isFadeIn = true;
        isFadeOut = false;
    }

    public void fadeOut()
    {
        isFadeOut = true;
        isFadeIn = false;
    }
}
