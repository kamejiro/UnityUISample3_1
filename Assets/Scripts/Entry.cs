using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entry : MonoBehaviour
{
    protected string name = "";
    public string Name
    {
        get
        {
            return this.name;
        }
    }

    //�ړ��������Ĉꗗ�����O�ɕ\������
    public abstract void PrintListLog(string prefix);

    //�ꗗ�����O�ɕ\������B
    public void PrintListLog()
    {
        PrintListLog("");
    }


    public override string ToString()
    {
        return this.name;
    }
}
