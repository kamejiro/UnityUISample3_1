using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button childMenu;

    //
    public void OnClickChildMenu()
    {
        Debug.Log(childMenu.GetComponentInChildren<Text>().text + "‚ª‰Ÿ‚³‚ê‚Ä‚é");
    }
}
