using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Xinput = Input.GetAxis("Horizontal");
        var Yinput = Input.GetAxis("Vertical");


        if (Xinput > 0)
        {
            transform.DORotate(new Vector3(0,0,-30), 0.1f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(0.8f, 0.1f);
            transform.DOScaleY(1.2f, 0.1f);
        }       
        if (Xinput < 0)
        {
            transform.DORotate(new Vector3(0, 0, 30), 0.1f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(0.8f, 0.1f);
            transform.DOScaleY(1.2f, 0.1f);
        }
        if (Xinput == 0)
        {
            transform.DORotate(new Vector3(0, 0, 0), 0.01f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(1, 0.1f);
            transform.DOScaleY(1, 0.1f);

        }

    }
}
