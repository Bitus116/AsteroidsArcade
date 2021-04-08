using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_script : MonoBehaviour {

    public GameObject Skins_panel;
    public GameObject Back_Button;
    public GameObject[] Skins;
    public GameObject Skin_Back_Button;
    public GameObject Skin_Next_Button;
    public GameObject Buy_Choice_Button;
    public int skinnum;
    private Vector3 pos;
    private Vector3 posprev;
    public int i = 1;

    private void Start()
    {
        skinnum = Skins.Length; 
    }
    public void OnBackButtonClick()
    {
        Skins_panel.SetActive(false);
    }
    public void OnBuyButtonClick()
    {

    }
    public void OnSkinNextButtonClick()
    {
        i++;
        posprev = Skins[i - 1].transform.position;
        pos = Skins[i].transform.position;
        while(pos.x != posprev.x)
        {
            pos.x--;
        }
        if (i == skinnum)
            Skin_Next_Button.SetActive(false);
    }
    public void OnSkinBackButtonClick()
    {
        i--;
        posprev = Skins[i + 1].transform.position;
        pos = Skins[i].transform.position;
        while (pos.x != posprev.x)
        {
            pos.x++;
        }
        if (i - skinnum == 0)
            Skin_Back_Button.SetActive(false);
    }
}
