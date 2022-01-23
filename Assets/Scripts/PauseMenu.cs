using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private void Start()
    {
        ToggleMenu(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_pauseMenu.activeInHierarchy)
            {
                ToggleMenu(false);
            }
            else
            {
                ToggleMenu(true);
            }
        }
    }

    public void ToggleMenu(bool state)
    {
        if (state)
        {
            Cursor.visible = true;
            Time.timeScale = 0;
            _pauseMenu.SetActive(true);
        }
        else
        {
            Cursor.visible = false;
            Time.timeScale = 1;
            _pauseMenu.SetActive(false);
        }    
    }
}
