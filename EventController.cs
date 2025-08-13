using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EventController : MonoBehaviour
{
    public static UnityAction<AudioType> OnPlayAudio;
 
    public static void RaiseOnPlayAudio(AudioType type)
    {
        OnPlayAudio?.Invoke(type);
    }
}