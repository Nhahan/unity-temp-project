using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "new Question")]
public class QuestionScript : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here";

    public string GetQuestion()
    {
        return question;
    }
}
