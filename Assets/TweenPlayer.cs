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
        if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
        {
            transform.DORotate(new Vector3(0,0,-30), 0.1f, RotateMode.Fast);
            transform.DOScaleX(0.8f, 0.1f);
            transform.DOScaleY(1.2f, 0.1f);
        }       
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.DORotate(new Vector3(0, 0, 30), 0.1f, RotateMode.Fast);
            transform.DOScaleX(0.8f, 0.1f);
            transform.DOScaleY(1.2f, 0.1f);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            transform.DORotate(new Vector3(0, 0, 0), 0.1f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(1, 0.1f);
            transform.DOScaleY(1, 0.1f);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            transform.DORotate(new Vector3(0, 0, 0), 0.1f, RotateMode.Fast).SetEase(Ease.OutBounce);
            transform.DOScaleX(1, 0.1f);
            transform.DOScaleY(1, 0.1f);
        }
    }
}
