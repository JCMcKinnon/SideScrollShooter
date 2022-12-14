using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

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

        if(Yinput > 0)
        {
            transform.DOScaleX(1.4f, 0.1f);
            transform.DOScaleY(0.6f, 0.1f);
        }
        if (Yinput < 0)
        {
           if(Xinput == 0)
            {
                transform.DOScaleX(0.6f, 0.1f);
                transform.DOScaleY(1.4f, 0.1f);
            }
           
        }

        if (!Input.anyKey && Xinput > -0.5f && Xinput < 0.5f)
        {
            transform.DORotate(new Vector3(0, 0, 0), 0.01f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(1, 0.01f);
            transform.DOScaleY(1, 0.01f);
            
        }
        if(Input.anyKey && Xinput == 0)
        {
            transform.DORotate(new Vector3(0, 0, 0), 0.01f, RotateMode.Fast).SetEase(Ease.OutBounce);

        }
        if (Input.anyKey && Xinput > 0)
        {
            if(Yinput > 0)
            {
                transform.DORotate(new Vector3(0, 0, 0), 0.01f, RotateMode.Fast).SetEase(Ease.OutBounce);

            }

            transform.DORotate(new Vector3(0,0,-30), 0.01f, RotateMode.Fast);
            transform.DOScaleX(1.2f, 0.1f);
            transform.DOScaleY(0.8f, 0.1f);
        }       
        if (Input.anyKey && Xinput < 0)
        {
             if(Yinput > 0)
             {
                transform.DORotate(new Vector3(0, 0, 0), 0.01f, RotateMode.Fast).SetEase(Ease.OutBounce);

             }
            transform.DORotate(new Vector3(0, 0, 30), 0.01f, RotateMode.Fast);
            transform.DOScaleX(1.2f, 0.1f);
            transform.DOScaleY(0.8f, 0.1f);
        }

   
    }
}
