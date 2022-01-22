using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlayers : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _vCam;

    [Header("Sphere Player: ")]
    [SerializeField] private bool _sphereActive;
    [SerializeField] private GameObject _spherePlayer;

    [Header("Cube Player: ")]
    [SerializeField] private bool _cubeActive;
    [SerializeField] private GameObject _cubePlayer;

    private Rigidbody _cubeRB;
    private Rigidbody _sphereRB;

    // Start is called before the first frame update
    void Start()
    {
        _cubeRB = _cubePlayer.GetComponent<Rigidbody>();
        _sphereRB = _spherePlayer.GetComponent<Rigidbody>();

        TogglePlayer(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (_sphereActive)
            {
                TogglePlayer(1);
            }
            else if (_cubeActive)
            {
                TogglePlayer(0);
            }
        }
    }

    void TogglePlayer(int playerID)
    {
        _spherePlayer.SetActive(false);
        _cubePlayer.SetActive(false);

        _sphereActive = false;
        _cubeActive = false;

        if (playerID == 0)
        {
            _spherePlayer.transform.position = _cubePlayer.transform.position;

            _spherePlayer.SetActive(true);

            _vCam.Follow = _spherePlayer.transform;
            _vCam.LookAt = _spherePlayer.transform;

            _sphereRB.velocity = _cubeRB.velocity;

            _sphereActive = true;
        }

        if (playerID == 1)
        {
            _cubePlayer.transform.position = _spherePlayer.transform.position;

            _cubePlayer.SetActive(true);

            _vCam.Follow = _cubePlayer.transform;
            _vCam.LookAt = _cubePlayer.transform;

            _cubeRB.velocity = _sphereRB.velocity;

            _cubeActive = true;
        }
    }
}
