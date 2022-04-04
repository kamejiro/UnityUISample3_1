using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SettingManager : MonoBehaviour
{
    //�Q�ƒ�`
    public InputField new_name;
    public Slider new_volume;

    //�ϐ���`
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
        //���̓e�L�X�g�̒l�𔽉f
        user_name = new_name.text;
        //�X���C�_�[�̒l�𔽉f
        volume = new_volume.value;
    }

    //�L�����Z���{�^��������
    public void OnClickCancel()
    {
        //�z�[���V�[���֖߂�
        SceneManager.LoadScene("SampleScene");
    }

    //OK�{�^��������
    public void OnClickOK()
    {
        //�X�V����ۑ�
        PlayerPrefs.SetString("user_name", user_name);
        PlayerPrefs.SetString("livingArea", livingArea);
        PlayerPrefs.SetInt("livingAreaNum", livingAreaNum);
        PlayerPrefs.SetString("sex", sex);
        PlayerPrefs.SetFloat("volume", volume);
        //�z�[���V�[���֖߂�
        SceneManager.LoadScene("SampleScene");
    }
}
