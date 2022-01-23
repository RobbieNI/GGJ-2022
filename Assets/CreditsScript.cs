using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
            UpdateTextMeshProText();
        }
    }

    private void UpdateTextMeshProText()
    {
        CreditsTextObject.text = CreditsText[currentLine];
    }
}
