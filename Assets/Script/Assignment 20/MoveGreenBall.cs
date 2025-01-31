using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class MoveGreenBall : MonoBehaviour
    {
        public float moveFactor = 0.1f;

        void Start()
        {

        }

        void Update()
        {
            /*..........................the green ball..........................*/

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(moveFactor, 0, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= new Vector3(moveFactor, 0, 0);
            }

            /*...................................................................*/

        }
    }
}
