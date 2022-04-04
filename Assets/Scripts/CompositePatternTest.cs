using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositePatternTest : MonoBehaviour
{
    //3�̃f�B���N�g�����`
    private GameItemDirectory itemDirectory = new GameItemDirectory("�A�C�e��");
    private GameItemDirectory consumptionItemDirectory = new GameItemDirectory("����A�C�e��");
    private GameItemDirectory equippedItemDirectory = new GameItemDirectory("�����A�C�e��");

    // Start is called before the first frame update
    void Start()
    {
        //�e�f�B���N�g���̊K�w��
        setupDirectories();

        //����A�C�e��n������A�C�e���f�B���N�g���ɐ���
        createConsumptionItemFilesTo(this.consumptionItemDirectory);
        //�����A�C�e��n�𑕔��A�C�e���f�B���N�g���ɐ���
        createEquippedItemFilesTo(this.equippedItemDirectory);

        this.itemDirectory.PrintListLog();
    }


    //�֐���`
    //�e�f�B���N�g���̊K�w�\��������
    private void setupDirectories()
    {
        this.itemDirectory.Add(this.consumptionItemDirectory);
        this.itemDirectory.Add(this.equippedItemDirectory);
    }

    //����A�C�e��n���w��f�B���N�g���ɐ���
    private void createConsumptionItemFilesTo(GameItemDirectory directory)
    {
        int fileNumber = 1;
        for(int i = 0; i < fileNumber; ++i)
        {
            int id = i + 1;
            string itemName = "����A�C�e��" + id;
            directory.Add(new GameItemFile(itemName));
        }
    }

    //�����A�C�e��n���w��f�B���N�g���ɐ���
    private void createEquippedItemFilesTo(GameItemDirectory directory)
    {
        int fileNumber = 2;
        for (int i = 0; i < fileNumber; ++i)
        {
            int id = i + 1;
            string itemName = "�����A�C�e��" + id;
            directory.Add(new GameItemFile(itemName));
        }
    }
}
