using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public static int money
    {
        get
        {
            if (!PlayerPrefs.HasKey("money")) PlayerPrefs.SetInt("money", 67); ;
            return PlayerPrefs.GetInt("money");
        }
        set
        {
            PlayerPrefs.SetInt("money", value);
        }
    }
}
