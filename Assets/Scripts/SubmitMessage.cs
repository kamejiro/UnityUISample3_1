using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SubmitMessage : MonoBehaviour
{
    //参照の定義
    public Text newTextPrefab;//生成するプレハブ
    public Transform textPosition;//送信したメッセージの位置
    public TextMeshProUGUI settingText;//設定のテキスト

    //変数定義
    string user_name;
    string livingArea;
    string sex;
    float volume;

    void Start()
    {
        //設定を取得
        user_name = "未設定";
        if (PlayerPrefs.HasKey("user_name"))
        {
            user_name = PlayerPrefs.GetString("user_name");
        }
        else
        {
            user_name = "未設定";
        }
        if (PlayerPrefs.HasKey("livingArea"))
        {
            livingArea = PlayerPrefs.GetString("livingArea");
        }
        else
        {
            livingArea = "未設定";
        }
        if (PlayerPrefs.HasKey("sex"))
        {
            sex = PlayerPrefs.GetString("sex");
        }
        else
        {
            sex = "男";
        }
        if (PlayerPrefs.HasKey("volume"))
        {
            volume = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            volume = 0;
        }
        //テキストを作成
        settingText.text = "名前：" + user_name + "\n性別：" + sex + "\n音量：" + volume + "\n出身地：" + livingArea;
    }

    void Update()
    {
        
    }

    //送信ボタンでメッセージを作成（UIプレハブ）
    public void submitText()
    {
        Text newText = Instantiate(newTextPrefab, textPosition.position, Quaternion.identity) as Text;
        newText.transform.SetParent(gameObject.transform, false);
    }

    //設定ボタンで設定シーンをロード。
    public void OnClickSetting()
    {
        SceneManager.LoadScene("SettingView");
    }
}
