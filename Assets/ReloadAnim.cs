using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class ReloadAnim : MonoBehaviour
{
    [SerializeField]
    GameObject GunModel;
   

    public void ReloadAnimation()
    {
        Sequence Reload = DOTween.Sequence();
        if (Reload.IsPlaying() == false)
        {
            Reload
                .Append(GunModel.transform.DOLocalMoveY(-0.065f, 0.15f, false).SetEase(Ease.InBack))
                .Append(
                    GunModel.transform
                        .DOLocalRotate(new Vector3(-360 * 3, 0, 0), 2f, RotateMode.LocalAxisAdd)
                        .SetEase(Ease.InOutBack)
                )
                .Append(
                    GunModel.transform.DOLocalMoveY(-0.125f, 0.15f, false).SetEase(Ease.OutBack)
                );
        }
        else
        {
            return;
        }
    }
}
