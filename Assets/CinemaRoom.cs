using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CinemaRoom : MonoBehaviour
{
    [SerializeField] private Transform[] walls;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private AudioSource audioSource;
    public void StartCinemaRoomEvents()
    {
        videoPlayer.Play();
        audioSource.Stop();
        StartCoroutine(WaitAndOpenExit());
    }

    private IEnumerator WaitAndOpenExit()
    {
        yield return new WaitForSeconds(10);
        LeanTween.moveZ(walls[0].gameObject, walls[0].localPosition.z -1, 1f);
        LeanTween.moveZ(walls[1].gameObject, walls[1].localPosition.z +1, 1f);
    }
}
