using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBtnUI : MonoBehaviour
{
    public void SetStatus(int status)
    {
        gameObject.SetActive(status == 1);
    }

    public void Hide()
    {
        if (gameObject.activeSelf) GetComponent<Animator>().Play("ArrowHide");
    }
}
