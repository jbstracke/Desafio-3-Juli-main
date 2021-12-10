using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameController : MonoBehaviour
{
    public helmetClass helmetClass;

    ItemBase itemClass;

    string json1 = (Application.dataPath + "/Resources/Text/json.json");

    string jsonSave;

    string jsonLoad;

    public Canvas canvas;

    Button button;

    public Button buttonSave;
    public Button buttonLoad;

    private void Start()
    {
        if (helmetClass.helmetDto != null) setItem();

        buttonSave.enabled = true;
        buttonLoad.enabled = true;

        buttonSave = button.GetComponent<Button>();
        buttonSave.onClick.AddListener(saveJson);

        buttonLoad = button.GetComponent<Button>();
        buttonSave.onClick.AddListener(loadJson);
    }

    private void Update()
    {
        var button1 = canvas.name.Equals(buttonSave);

        if(Input.GetKeyDown(KeyCode.Space))
        saveJson();

        var button2 = canvas.name.Equals(buttonLoad);

        if (Input.GetKeyDown(KeyCode.L))
        loadJson();
    }

    public void setItem()
    {

        var _nameItem = itemClass.nameItem;
        _nameItem = "itemName";

        var _itemType = itemClass.itemType;
        _itemType = 2;

        var _itemDmg = itemClass.itemDmg;
        _itemDmg = 5;

        var _itemMana = itemClass.itemMana;
        itemClass.itemMana = 4;

        var _itemDef = itemClass.itemDef;
        _itemDef = 2;

    }

    public void saveJson()
    {
        jsonSave = JsonUtility.ToJson(json1, true);
  
        File.WriteAllText(Application.dataPath + "/Resources/Text/json.json", jsonSave);

        Debug.Log("salvou");
    }


     public void loadJson()
    {
        //jsonLoad = JsonUtility.FromJson.json1(json1); ;
        

        //File.ReadAllText(Application.dataPath + "/Resources/Text/json.json", jsonLoad);

        Debug.Log("leu");

        //Debug.Log(jsonSave);
    }



}
