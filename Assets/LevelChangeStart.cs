using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeStart : MonoBehaviour
{
    [SerializeField] private int index;

    public void loadlevel()
    {
        SceneManager.LoadScene(index);
    }
}
