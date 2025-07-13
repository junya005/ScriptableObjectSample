using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCoutNuberScriptableObject", menuName = "ScriptableObject/CountNuberData")]
public class CountNumberScriptableObject : ScriptableObject
{
    public int countNumber;

    public void SetCountNumber(int value)
    {
        countNumber = value;
    }
}
