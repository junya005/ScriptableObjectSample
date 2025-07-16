using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ScriptableObjectを継承することで、データアセットを作ることができる
// CreateAssetMenuはデータアセットを作るための属性を付与する記述。
// この場合だと、ProjectウィンドウのCreateからScriptableObject/CountNuberDataのパスに作るためのメニューを追加する。
[CreateAssetMenu(fileName = "newCoutNuberScriptableObject", menuName = "ScriptableObject/CountNuberData")]
public class CountNumberScriptableObject : ScriptableObject
{
    // データの内容(保存したい値の変数)
    public int countNumber;

    // 保存したい値を変更するための関数
    public void SetCountNumber(int value)
    {
        countNumber = value;
    }
}
