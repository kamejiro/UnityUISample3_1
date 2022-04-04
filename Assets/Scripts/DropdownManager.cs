using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    //参照定義
    [SerializeField] private Dropdown dropdown;

    void Start()
    {
        //playerprefsの値を現在のドロップダウンに設定
        dropdown.value= PlayerPrefs.GetInt("livingAreaNum");
    }

    void Update()
    {

    }

    //ドロップダウンがクリックされたとき
    public void OnClickDropdown()
    {
        //設定画面スクリプトで定義した変数に現在の値を代入。
        SettingManager.livingAreaNum = dropdown.value;
        SettingManager.livingArea = dropdown.options[dropdown.value].text;
    }
}
