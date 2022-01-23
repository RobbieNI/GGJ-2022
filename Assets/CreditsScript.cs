using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    [SerializeField] private string[] CreditsText;
    [SerializeField] private TextMeshProUGUI CreditsTextObject;
    
    private int currentLine = 0;

    private void Awake()
    {
        UpdateTextMeshProText();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentLine++;

            if (currentLine == CreditsText.Length)
            {
                SceneManager.LoadScene("MenuScene");
            }
            else
            {
                UpdateTextMeshProText();
            }
        }
    }

    private void UpdateTextMeshProText()
    {
        CreditsTextObject.text = CreditsText[currentLine];

    }
}
