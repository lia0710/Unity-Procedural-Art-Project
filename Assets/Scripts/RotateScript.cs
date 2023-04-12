using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    float timing = 70f;
    // Update is called once per frame
    void Update()
    {
        timing = timing - Time.deltaTime;
        if (timing >= 0)
        {
            transform.Rotate(0f, 22.5f * Time.deltaTime, 0f);
        }
        else if (transform.rotation.eulerAngles.y % 90 != 0)
        {
            if (transform.rotation.eulerAngles.y % 90 > 90f - 1f)
            {
                transform.Rotate(0f, 90-transform.rotation.eulerAngles.y%90, 0f);
            }
            else
            {
                transform.Rotate(0f, 22.5f * Time.deltaTime, 0f);
            }
        }
    }
}
