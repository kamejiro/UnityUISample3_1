using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemDirectory : Entry
{
    //要素のリスト
    private List<Entry> directory = new List<Entry>();

    //コンストラクタ
    public GameItemDirectory(string name)
    {
        this.name = name;
    }

    //ディレクトリに新しい要素を追加
    public Entry Add(Entry entry)
    {
        this.directory.Add(entry);
        return this;
    }
    public override void PrintListLog(string prefix)
    {
        //いったん出力
        Debug.Log(prefix + "/" + this);

        //
        foreach(var element in this.directory)
        {
            Entry entry = (Entry)element;
            entry.PrintListLog(prefix + "/" + this);
        }
    }
}
