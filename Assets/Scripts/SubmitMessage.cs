using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SubmitMessage : MonoBehaviour
{
    //�Q�Ƃ̒�`
    public Text newTextPrefab;//��������v���n�u
    public Transform textPosition;//���M�������b�Z�[�W�̈ʒu
    public TextMeshProUGUI settingText;//�ݒ�̃e�L�X�g

    //�ϐ���`
    string user_name;
    string livingArea;
    string sex;
    float volume;

    void Start()
    {
        //�ݒ���擾
        user_name = "���ݒ�";
        if (PlayerPrefs.HasKey("user_name"))
        {
            user_name = PlayerPrefs.GetString("user_name");
        }
        else
        {
            user_name = "���ݒ�";
        }
        if (PlayerPrefs.HasKey("livingArea"))
        {
            livingArea = PlayerPrefs.GetString("livingArea");
        }
        else
        {
            livingArea = "���ݒ�";
        }
        if (PlayerPrefs.HasKey("sex"))
        {
            sex = PlayerPrefs.GetString("sex");
        }
        else
        {
            sex = "�j";
        }
        if (PlayerPrefs.HasKey("volume"))
        {
            volume = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            volume = 0;
        }
        //�e�L�X�g���쐬
        settingText.text = "���O�F" + user_name + "\n���ʁF" + sex + "\n���ʁF" + volume + "\n�o�g�n�F" + livingArea;
    }

    void Update()
    {
        
    }

    //���M�{�^���Ń��b�Z�[�W���쐬�iUI�v���n�u�j
    public void submitText()
    {
        Text newText = Instantiate(newTextPrefab, textPosition.position, Quaternion.identity) as Text;
        newText.transform.SetParent(gameObject.transform, false);
    }

    //�ݒ�{�^���Őݒ�V�[�������[�h�B
    public void OnClickSetting()
    {
        SceneManager.LoadScene("SettingView");
    }
}
