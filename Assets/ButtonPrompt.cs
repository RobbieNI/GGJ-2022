using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonPrompt : MonoBehaviour
{
    [SerializeField] private GameObject _UIObject;
    [SerializeField] private TextMeshProUGUI _tmp;

    public static Action showUI;

    private void Awake()
    {
        TriggerActivateButtonPress.inInteractiveTriggerZone += ShowUIPrompt;
        TriggerActivateButtonPress.leavingInteractiveTriggerZone += HideUIPrompt;
    }

    private void OnDestroy()
    {
        TriggerActivateButtonPress.inInteractiveTriggerZone -= ShowUIPrompt;
        TriggerActivateButtonPress.leavingInteractiveTriggerZone -= HideUIPrompt;
    }

    private void HideUIPrompt()
    {
        _UIObject.SetActive(false);
    }

    private void ShowUIPrompt(string uiMessage)
    {
        _tmp.text = uiMessage;
        _UIObject.SetActive(true);
    }
}
