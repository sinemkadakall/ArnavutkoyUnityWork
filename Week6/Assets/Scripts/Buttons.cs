using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public InputField iField;
    public InputField iField2;
    public InputField iField3;
    public Dropdown dropdown;
    public Dropdown dropdown2;
    public Toggle toggle;
    public Toggle toggle2;

   public void paneleGec()
    {
        panel.gameObject.SetActive(true);
        Destroy(button);

    }
    public void bilgileriAl()
    {
        string inputText = "Ad:" + iField.text + "    " + "Soyad:" + iField2.text ;
        Debug.Log(inputText);

        string selectedText ="E�itim:"+ dropdown.options[dropdown.value].text+"       "+"Unity Bilgi D�zeyi: "+ dropdown2.options[dropdown2.value].text;
        Debug.Log(selectedText);

        string toggleText = toggle.isOn ? toggle.GetComponentInChildren<Text>().text : "Hay�r";
        Debug.Log("Daha �nce e�itim alm�� m�:"+toggleText);

        string iText = "Beklenti:" + iField3.text;
        Debug.Log(iText);
    }
}
