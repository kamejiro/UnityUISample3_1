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

    //接頭辞をつけて一覧をログに表示する
    public abstract void PrintListLog(string prefix);

    //一覧をログに表示する。
    public void PrintListLog()
    {
        PrintListLog("");
    }


    public override string ToString()
    {
        return this.name;
    }
}
