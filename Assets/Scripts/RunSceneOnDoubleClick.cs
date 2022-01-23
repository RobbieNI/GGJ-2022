using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RunSceneOnDoubleClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string _sceneToLoad;
    [SerializeField] private PauseMenu _pauseScript;

    public void OnDoubleClick()
    {
        if (_sceneToLoad == "PauseMenu")
        {
            _pauseScript.ToggleMenu(false);
        }
        else
        {
            SceneManager.LoadScene(_sceneToLoad);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int clickCount = eventData.clickCount;

        if (clickCount == 2)
        {
            OnDoubleClick();
        }
    }
}
