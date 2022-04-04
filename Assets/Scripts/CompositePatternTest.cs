using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositePatternTest : MonoBehaviour
{
    //3つのディレクトリを定義
    private GameItemDirectory itemDirectory = new GameItemDirectory("アイテム");
    private GameItemDirectory consumptionItemDirectory = new GameItemDirectory("消費アイテム");
    private GameItemDirectory equippedItemDirectory = new GameItemDirectory("装備アイテム");

    // Start is called before the first frame update
    void Start()
    {
        //各ディレクトリの階層化
        setupDirectories();

        //消費アイテムn個を消費アイテムディレクトリに生成
        createConsumptionItemFilesTo(this.consumptionItemDirectory);
        //装備アイテムn個を装備アイテムディレクトリに生成
        createEquippedItemFilesTo(this.equippedItemDirectory);

        this.itemDirectory.PrintListLog();
    }


    //関数定義
    //各ディレクトリの階層構造を準備
    private void setupDirectories()
    {
        this.itemDirectory.Add(this.consumptionItemDirectory);
        this.itemDirectory.Add(this.equippedItemDirectory);
    }

    //消費アイテムn個を指定ディレクトリに生成
    private void createConsumptionItemFilesTo(GameItemDirectory directory)
    {
        int fileNumber = 1;
        for(int i = 0; i < fileNumber; ++i)
        {
            int id = i + 1;
            string itemName = "消費アイテム" + id;
            directory.Add(new GameItemFile(itemName));
        }
    }

    //装備アイテムn個を指定ディレクトリに生成
    private void createEquippedItemFilesTo(GameItemDirectory directory)
    {
        int fileNumber = 2;
        for (int i = 0; i < fileNumber; ++i)
        {
            int id = i + 1;
            string itemName = "装備アイテム" + id;
            directory.Add(new GameItemFile(itemName));
        }
    }
}
