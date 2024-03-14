using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelContainer : MonoBehaviour
{

    [Header("GameObject Configuration")]
    //Aqui estan las variables para las lecciones, cuantas lecciones son y si la leccion esta completa.
    public int Lection = 0;
    public int currentLession = 0;
    public int TotalLession = 0;
    public bool AreAllLessonsComplete = false;
    //Aqui se generan los textos.
    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;
    //Este es el GameObject que contiene las lecciones.
    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;
    //Este ScriptableObject lee las lecciones.
    [Header("Lesson Data")]
    public ScriptableObject LessonData;

    // Start is called before the first frame update
    void Start()
    {
        //Se actualiza el lessonContainer y se va a OnUpdateUi.
        if (lessonContainer != null)
        {
            OnUpdateUI();
        }

        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo GameObject lessonContainer");
        }

    }

    public void OnUpdateUI()
    {
        // Se accede a los textos de stagetitle y lessonStange 
        if (StageTitle != null || LessonStage != null)
        {
            //Se muestra en la UI la leccion y su seccion de cada una
            StageTitle.text = "Leccion " + Lection;
            LessonStage.text = "Leccion " + currentLession + " de " + TotalLession;
        }

        else
        {
            //Si no estan los textos se manda un mensaje.
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo TMP_text");
        }
    }
    //este meotodo activa y desactiva la ventana lessonContainer
    public void EnableWindow()
    {
        OnUpdateUI();
        //Hace que desaparezco y aparezca la ventana de lessonContainer
        if (lessonContainer.activeSelf)
        {
            //Desactiva el objecto si esta activo
            lessonContainer.SetActive(false);
        }

        else
        {
            //Activa el objecto si esta desactivado
            lessonContainer.SetActive(true);
        }
    }

}
    
  
