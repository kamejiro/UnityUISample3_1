using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    //�Q�ƒ�`
    public Toggle toggleMale;
    public Toggle toggleFemale;

    void Start()
    {
        //playerprefs�̒l�����݂̃g�O���ɐݒ�
        if (PlayerPrefs.GetString("sex")=="�j")
        {
            toggleMale.isOn = true;
            toggleFemale.isOn = false;
        }
        if (PlayerPrefs.GetString("sex") == "��")
        {
            toggleMale.isOn = false;
            toggleFemale.isOn = true;
        }
    }

    //�g�O�����N���b�N���ꂽ�Ƃ�
    public void OnClickToggle()
    {
        //�ݒ��ʃX�N���v�g�Œ�`����sex�ϐ��Ɍ��݂̒l�����B
        if (toggleMale.isOn)
        {
            SettingManager.sex = "�j";
        }
        if (toggleFemale.isOn)
        {
            SettingManager.sex = "��";
        }
    }
}
