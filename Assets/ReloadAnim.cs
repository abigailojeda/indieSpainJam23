using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ReloadAnim : MonoBehaviour
{
    [SerializeField] GameObject GunModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadAnimation() {
        Sequence Reload = DOTween.Sequence();
        Reload.Append(GunModel.transform.DOLocalMoveY(0.95f,0.1f,false))
        .Append(GunModel.transform.DOLocalRotate(new Vector3(360*2,0,0),1f,RotateMode.LocalAxisAdd))
        .Append(GunModel.transform.DOLocalMoveY(0.875f,0.1f,false));
    }
}
