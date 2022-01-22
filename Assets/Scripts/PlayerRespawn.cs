using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRespawn : MonoBehaviour
{
    [Header("Properties: ")]
    [SerializeField] private float _respawnDelay;

    [Header("References: ")]
    [SerializeField] private Rigidbody _rigidbody;

    private WaitForSeconds _respawnDelayWaitTime;
    public static Action<bool> _toggleInput;
    public static Action _toggleDeathScreen;

    [Header("Events: ")]
    [SerializeField] private UnityEvent _onPlayerDeath;
    [SerializeField] private UnityEvent _onPlayerRespawn;

    private void Awake()
    {
        RespawnAtPoint.respawnAtPoint += RespawnPlayer;
    }

    private void OnDestroy()
    {
        RespawnAtPoint.respawnAtPoint -= RespawnPlayer;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _respawnDelayWaitTime = new WaitForSeconds(_respawnDelay);
    }

    public void RespawnPlayer(Transform respawnPosition)
    {
        if (gameObject.activeSelf)
        {
            _onPlayerDeath.Invoke();
            StartCoroutine(RespawnPlayerAfterTime(respawnPosition));
        }
    }

    IEnumerator RespawnPlayerAfterTime(Transform respawnPosition)
    {
        _toggleDeathScreen?.Invoke();
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.Sleep();

        transform.position = respawnPosition.position;
        _toggleInput?.Invoke(false);

        yield return _respawnDelayWaitTime;

        _onPlayerRespawn.Invoke();
        _toggleInput?.Invoke(true);
        _toggleDeathScreen?.Invoke();
    }
}