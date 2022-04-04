using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemDirectory : Entry
{
    //�v�f�̃��X�g
    private List<Entry> directory = new List<Entry>();

    //�R���X�g���N�^
    public GameItemDirectory(string name)
    {
        this.name = name;
    }

    //�f�B���N�g���ɐV�����v�f��ǉ�
    public Entry Add(Entry entry)
    {
        this.directory.Add(entry);
        return this;
    }
    public override void PrintListLog(string prefix)
    {
        //��������o��
        Debug.Log(prefix + "/" + this);

        //
        foreach(var element in this.directory)
        {
            Entry entry = (Entry)element;
            entry.PrintListLog(prefix + "/" + this);
        }
    }
}
