using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeforeSceneManager : MonoBehaviour
{
    [SerializeField]
    private CountNumberScriptableObject _countNuberScriptableObject;

    private int _countNum;

    [SerializeField]
    private TextMeshProUGUI _countNumText;

    // Start is called before the first frame update
    void Start()
    {
        _countNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _countNumText.text = _countNum.ToString();
    }

    public void OnClickButton()
    {
        _countNum++;
        _countNuberScriptableObject.SetCountNumber(_countNum);
    }
}
