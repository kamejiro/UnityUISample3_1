using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    //参照定義
    public Toggle toggleMale;
    public Toggle toggleFemale;

    void Start()
    {
        //playerprefsの値を現在のトグルに設定
        if (PlayerPrefs.GetString("sex")=="男")
        {
            toggleMale.isOn = true;
            toggleFemale.isOn = false;
        }
        if (PlayerPrefs.GetString("sex") == "女")
        {
            toggleMale.isOn = false;
            toggleFemale.isOn = true;
        }
    }

    //トグルがクリックされたとき
    public void OnClickToggle()
    {
        //設定画面スクリプトで定義したsex変数に現在の値を代入。
        if (toggleMale.isOn)
        {
            SettingManager.sex = "男";
        }
        if (toggleFemale.isOn)
        {
            SettingManager.sex = "女";
        }
    }
}
