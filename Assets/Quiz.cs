using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI questionText;
  [SerializeField] QuestionScript question;
  [SerializeField] GameObject[] answerButtons;

  void Start()
  {
    questionText.text = question.GetQuestion();

    for (int i = 0; i < answerButtons.Length; i++)
    {
      TextMeshProUGUI buttonText = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
      buttonText.text = questionText.getAnswer(0);
    }
  }
}