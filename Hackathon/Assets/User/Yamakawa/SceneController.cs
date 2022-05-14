using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class SceneController : MonoBehaviour
{

    Player script;
    public GameObject fadeCanvas;//操作するCanvas、タグで探す

    void Start()
    {
        Invoke("findFadeObject", 0.02f);//起動時用にCanvasの召喚をちょっと待つ
    }

    void findFadeObject()
    {
        fadeCanvas = GameObject.FindGameObjectWithTag("Fade");//Canvasをみつける
        fadeCanvas.GetComponent<FadeManager>().fadeIn();//フェードインフラグを立てる
    }

    public async void sceneChange(string sceneName)//ボタン操作などで呼び出す
    {
        fadeCanvas.GetComponent<FadeManager>().fadeOut();//フェードアウトフラグを立てる
        await Task.Delay(200);//暗転するまで待つ
        SceneManager.LoadScene("GameScene");//シーンチェンジ
    }
}
