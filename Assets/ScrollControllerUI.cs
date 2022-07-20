using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollControllerUI : MonoBehaviour
{
    private ScrollRect scrollRect;

    public ScrollBtnUI leftBtn;
    public ScrollBtnUI rightBtn;

    private float delta;

    private void Start()
    {
        scrollRect.horizontalNormalizedPosition = 0;
    }

    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    public void Left()
    {
        delta -= 0.13f;
    }

    public void Right()
    {
        delta += 0.13f;
    }

    void Update()
    {
        float pos = scrollRect.horizontalNormalizedPosition;
        float dist = 1 - pos;
        if (pos < 0.001f) leftBtn.Hide();
        if (dist < 0.001f) rightBtn.Hide();
        if (dist > 0.001f && pos > 0.001f)
        {
            leftBtn.gameObject.SetActive(true);
            rightBtn.gameObject.SetActive(true);
        }
        float newPos = Mathf.Lerp(pos, pos + delta, Time.deltaTime * 5);
        scrollRect.horizontalNormalizedPosition = Mathf.Max(0, Mathf.Min(1, newPos));
        delta -= delta * Time.deltaTime;
    }
}
