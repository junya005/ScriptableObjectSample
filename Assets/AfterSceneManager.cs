using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfterSceneManager : MonoBehaviour
{
    // 目的の値が保存されたデータアセットを設定
    [SerializeField]
    private CountNumberScriptableObject _countNuberScriptableObject;

    // 目的の値を表示するテキストを設定
    [SerializeField]
    private TextMeshProUGUI _countNumText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 目的の値を表示するためのボタンに設定する関数
    public void OnClickButton()
    {
        _countNumText.text = _countNuberScriptableObject.countNumber.ToString();
    }
}
