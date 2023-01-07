using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonVFX : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private ParticleSystem _particleSystem;

    public void OnPointerClick(PointerEventData eventData)
    {
        _particleSystem.Play();
    }
}
