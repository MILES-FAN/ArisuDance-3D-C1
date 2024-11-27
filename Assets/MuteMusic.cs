using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MuteMusic : MonoBehaviour
{
    public AudioSource music;
    bool isMuted = false;

    public void ToggleMute()
    {
        isMuted = !isMuted;
        music.mute = isMuted;
        EventSystem.current.SetSelectedGameObject(null);
    }
}
