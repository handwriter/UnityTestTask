using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardUI : MonoBehaviour
{
    public TMP_Text readyText;
    public TMP_Text totalText;

    public int index;

    public void OnPlayBtnClick()
    {
        ViewController.instance.PlayBtnClick(index);
        ViewController.instance.ChangeMoney(10);
    }
}
