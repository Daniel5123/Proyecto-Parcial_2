using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option : MonoBehaviour
{
    public int OptionId;
    public string OptionName;

    public void Start()
    {
        //Se adquiere el nombre del scriptableObject y la opcion de texto
        transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    }

    void Update()
    {
        
    }
    //Se actualiza el texto
    public void Updatetext()
    {
        //Conforme pasen las preguntas se actualiza el texto
        transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    }
    public void SelectOptions()
    {
        LevelManager.Instance.setPlayerAnswer(OptionId);
        LevelManager.Instance.CheckPlayerState();
    }
}
