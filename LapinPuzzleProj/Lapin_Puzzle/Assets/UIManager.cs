using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;
    public static UIManager sharedInstance
    {

        //Accesseur automatique
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<UIManager>();
            }
            return instance;
        }
    }

    public Image BlackBG;

    public Image BlackCurtain;

    public GameObject victory;

    private CanvasGroup victoryCG;
    private RectTransform victoryRect;


    void Start()
    {
        BlackBG.DOFade(0f, 0f);

        DOTween.SetTweensCapacity(500, 20);

        victoryCG = victory.GetComponent<CanvasGroup>();
        victoryRect = victory.GetComponent<RectTransform>();

        victoryCG.alpha = 0f;
        victoryRect.DOScale(0f, 0f);
        victoryCG.blocksRaycasts = false;
        victoryCG.interactable = false;
    }

    void Update()
    {

    }
    public void VictoryAnim()
    {
        FadeBG(true);

        victoryCG.alpha = 1f;
        victoryRect.DOScale(1, 0.5f).SetEase(Ease.OutBack);
    }

    public void FadeBG(bool value)
    {
        if (value)
        {
            BlackBG.DOFade(0.56f, 0.5f);
        }
        else
        {
            BlackBG.DOFade(0f, 0.3f);
        }
    }
    public void FadeCurtain(bool value)
    {
        if (value)
        {
            BlackCurtain.DOFade(1f, 0.5f);
        }
        else
        {
            BlackCurtain.DOFade(0f, 0.3f);
        }
    }

}
