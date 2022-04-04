using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemFile : Entry
{
    //コンストラクタ
    public GameItemFile(string name)
    {
        this.name = name;
    }

    public override void PrintListLog(string prefix)
    {
        Debug.Log(prefix + "/" + this);
    }
}
