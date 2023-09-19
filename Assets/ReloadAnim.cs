using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ReloadAnim : MonoBehaviour
{
    [SerializeField] GameObject GunModel;

    public void ReloadAnimation() {
        Sequence Reload = DOTween.Sequence();
        Reload.Append(GunModel.transform.DOLocalMoveY(0.95f,0.15f,false).SetEase(Ease.InBack))
        .Append(GunModel.transform.DOLocalRotate(new Vector3(-360*6,0,0), 2f,RotateMode.LocalAxisAdd).SetEase(Ease.InOutBack))
        .Append(GunModel.transform.DOLocalMoveY(0.875f,0.15f,false).SetEase(Ease.OutBack));
    }
}
