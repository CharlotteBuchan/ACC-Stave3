﻿using System.Collections;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    private QuestionCollection questionCollection;
    private QuizQuestion currentQuestion;
    private UIController uiController;

    [SerializeField]
    private float delayBetweenQuestions = 3f;

    private void Awake()
    {
        questionCollection = FindObjectOfType<QuestionCollection>();
        
        uiController = FindObjectOfType<UIController>();
    }

    private void Start()
    {
        PresentQuestion();
    }

    private void PresentQuestion()
    {
        currentQuestion = questionCollection.GetUnaskedQuestion();
        uiController.SetupUIForQuestion(currentQuestion);
    }

    public void SubmitAnswer(int answerNumber)
    {
        bool isCorrect = answerNumber == currentQuestion.CorrectAnswer;
        uiController.HandleSubmittedAnswer(isCorrect);
        
        StartCoroutine(ShowNextQuestionAfterDelay());
    }

    private IEnumerator ShowNextQuestionAfterDelay()
    {
        yield return new WaitForSeconds(delayBetweenQuestions);
        PresentQuestion();
    }
}