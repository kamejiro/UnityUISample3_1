using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SettingManager : MonoBehaviour
{
    //参照定義
    public InputField new_name;
    public Slider new_volume;

    //変数定義
    string user_name;
    float volume;
    public static int livingAreaNum;
    public static string livingArea;
    public static string sex;

    void Start()
    {
        new_name = new_name.GetComponent<InputField>();
        new_name.text = PlayerPrefs.GetString("user_name");

        new_volume = new_volume.GetComponent<Slider>();
        float maxVol = 100;
        new_volume.maxValue = maxVol;
        new_volume.value = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
        //入力テキストの値を反映
        user_name = new_name.text;
        //スライダーの値を反映
        volume = new_volume.value;
    }

    //キャンセルボタン押下時
    public void OnClickCancel()
    {
        //ホームシーンへ戻る
        SceneManager.LoadScene("SampleScene");
    }

    //OKボタン押下時
    public void OnClickOK()
    {
        //更新情報を保存
        PlayerPrefs.SetString("user_name", user_name);
        PlayerPrefs.SetString("livingArea", livingArea);
        PlayerPrefs.SetInt("livingAreaNum", livingAreaNum);
        PlayerPrefs.SetString("sex", sex);
        PlayerPrefs.SetFloat("volume", volume);
        //ホームシーンへ戻る
        SceneManager.LoadScene("SampleScene");
    }
}
