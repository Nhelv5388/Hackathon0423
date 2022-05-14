using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class SceneController : MonoBehaviour
{

    Player script;
    public GameObject fadeCanvas;//���삷��Canvas�A�^�O�ŒT��

    void Start()
    {
        Invoke("findFadeObject", 0.02f);//�N�����p��Canvas�̏�����������Ƒ҂�
    }

    void findFadeObject()
    {
        fadeCanvas = GameObject.FindGameObjectWithTag("Fade");//Canvas���݂���
        fadeCanvas.GetComponent<FadeManager>().fadeIn();//�t�F�[�h�C���t���O�𗧂Ă�
    }

    public async void sceneChange(string sceneName)//�{�^������ȂǂŌĂяo��
    {
        fadeCanvas.GetComponent<FadeManager>().fadeOut();//�t�F�[�h�A�E�g�t���O�𗧂Ă�
        await Task.Delay(200);//�Ó]����܂ő҂�
        SceneManager.LoadScene("GameScene");//�V�[���`�F���W
    }
}
