using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ViewController : MonoBehaviour
{
    public CounterUI counterUI;

    private static ViewController viewController;

    public CardUI[] cards;

    [Serializable]
    public class Level
    {
        public int ready;
        public int total;
    }

    public Level[] levels;

    public void PlayBtnClick(int index)
    {
        levels[index].ready = (int)MathF.Min(levels[index].total, levels[index].ready + 1);
        cards[index].readyText.text = levels[index].ready.ToString();
        cards[index].totalText.text = levels[index].total.ToString();
    }

    private void Start()
    {
        counterUI.count = ModelController.money;
        counterUI.countText.text = ModelController.money.ToString();

        for (int i = 0;i < levels.Length;i++)
        {
            cards[i].totalText.text = levels[i].total.ToString();
            cards[i].readyText.text = levels[i].ready.ToString();
        }
    }

    public static ViewController instance
    {
        get
        {
            if (viewController == null) viewController = GameObject.Find("View").GetComponent<ViewController>();
            return viewController;
        }
    }

    public void OnInfoBtnClick()
    {
        Debug.Log("INFO BTN CLICK");
    }

    public void OnRestoreBtnClick()
    {
        Debug.Log("RESTORE BTN CLICK");
    }

    public void ChangeMoney(int delta)
    {
        counterUI.delta += delta;
        counterUI.VisualChange();
        ModelController.money += delta;
    }
}
