using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BeforeSceneManager : MonoBehaviour
{
    // 目的の値を保存するためのデータアセット(作ったScriptableObject)を設定
    [SerializeField]
    private CountNumberScriptableObject _countNuberScriptableObject;

    // 目的の値
    private int _countNum;

    // 目的の値を表示するテキストを設定
    [SerializeField]
    private TextMeshProUGUI _countNumText;

    // Start is called before the first frame update
    void Start()
    {
        // 目的の値を初期化
        _countNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // テキストを表示
        _countNumText.text = _countNum.ToString();
    }

// カウントボタンに設定する関数
    public void OnClickButton()
    {
        // カウント番号を増やす
        _countNum++;

        // ScriptableObjectに保存する
        _countNuberScriptableObject.SetCountNumber(_countNum);
    }

    // 次のシーンへ移動するボタンに設定する関数
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
