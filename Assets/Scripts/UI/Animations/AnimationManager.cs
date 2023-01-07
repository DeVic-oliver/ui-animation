using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class AnimationManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private float _scaleSize = 1.2f;
    [SerializeField] private float _transitionDurantion = 0.2f;

    private Vector3 _originalScale;

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_scaleSize, _transitionDurantion).From(_originalScale);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_originalScale, _transitionDurantion).From(_scaleSize);
    }

    private void Awake()
    {
        _originalScale = transform.localScale;
    }
}
