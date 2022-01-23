using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaleBounce : MonoBehaviour
{
    Vector3 startScale;
    Vector3 endScale = new Vector3(1.2f,1.2f,1.2f);
    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(startScale, endScale, Mathf.PingPong(Time.time, .42f));

        //if (transform.localScale == endScale)
        //{
        //    endScale = startScale;
        //}
        //else if (transform.localScale == startScale)
        //{
        //    endScale = new Vector3(1.2f, 1.2f, 1.2f);
        //}


    }
}
