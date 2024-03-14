using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

    public class Leccion
    {
        //Las opciones que da el programa para dar las preguntas
        public int ID;
        public string lessons;
        public List<string> opciones;
        public int correctAnswer;
    }

