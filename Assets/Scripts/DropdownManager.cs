using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    //�Q�ƒ�`
    [SerializeField] private Dropdown dropdown;

    void Start()
    {
        //playerprefs�̒l�����݂̃h���b�v�_�E���ɐݒ�
        dropdown.value= PlayerPrefs.GetInt("livingAreaNum");
    }

    void Update()
    {

    }

    //�h���b�v�_�E�����N���b�N���ꂽ�Ƃ�
    public void OnClickDropdown()
    {
        //�ݒ��ʃX�N���v�g�Œ�`�����ϐ��Ɍ��݂̒l�����B
        SettingManager.livingAreaNum = dropdown.value;
        SettingManager.livingArea = dropdown.options[dropdown.value].text;
    }
}
