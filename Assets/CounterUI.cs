using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class CounterUI : MonoBehaviour
{
    public int count;
    public int delta;
    public TMP_Text countText;
    public float percent;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        UpdateRect();
    }

    private void UpdateRect()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }

    public void VisualChange()
    {
        animator.Play("NewScore");
    }

    private void Update()
    {
        if (countText == null || delta == 0) return;
        countText.text = (count + (int)(delta * percent)).ToString();
        if (percent == 1)
        {
            count += delta;
            delta = 0;
        }
    }
}
