using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    float timing = 0.1f;
    float r = 0;
    float g = 0;
    float b = 0;
    float rgoal = 0;
    float ggoal = 0;
    float bgoal = 0;
    float bound = 0.05f;
    float finaltiming = 60;

    // Update is called once per frame
    void Update()
    {
        timing = timing - Time.deltaTime;
        finaltiming = finaltiming - Time.deltaTime;
        if (finaltiming < 0)
        {
            rgoal = 0;
            ggoal = 0;
            bgoal = 0;
            bound = 0.001f;

            if (r + bound < rgoal)
            {
                r = r + bound;
            }
            else if (r - bound > rgoal)
            {
                r = r - bound;
            }
            else if (r != rgoal)
            {
                r = rgoal;
            }


            if (g + bound < ggoal)
            {
                g = g + bound;
            }
            else if (g - bound > ggoal)
            {
                g = g - bound;
            }
            else if (g != ggoal)
            {
                g = ggoal;
            }

            if (b + bound < bgoal)
            {
                b = b + bound;
            }
            else if (b - bound > bgoal)
            {
                b = b - bound;
            }
            else if (b != bgoal)
            {
                b = bgoal;
            }

            gameObject.GetComponent<Renderer>().material.color = new Color(r, g, b);
        }
        else if (timing <= 0)
        {
            timing = 0.1f;
            if (r + bound < rgoal)
            {
                r = r + bound;
            }
            else if (r - bound > rgoal)
            {
                r = r - bound;
            }
            else if (r != rgoal)
            {
                r = rgoal;
            }


            if (g + bound < ggoal)
            {
                g = g + bound;
            }
            else if (g - bound > ggoal)
            {
                g = g - bound;
            }
            else if (g != ggoal)
            {
                g = ggoal;
            }

            if (b + bound < bgoal)
            {
                b = b + bound;
            }
            else if (b - bound > bgoal)
            {
                b = b - bound;
            }
            else if (b != bgoal)
            {
                b = bgoal;
            }

            gameObject.GetComponent<Renderer>().material.color = new Color(r,g,b);

            if (r == rgoal && g == ggoal && b == bgoal)
            {
                rgoal = Random.Range(0f, 1f);
                bgoal = Random.Range(0f, 1f);
                ggoal = Random.Range(0f, 1f);
            }
        }
    }
}
