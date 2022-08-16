using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Xaxis = Input.GetAxis("Horizontal");
        var yAxis = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(Xaxis * 0.09f,yAxis * 0.09f, 0));
    }
}
