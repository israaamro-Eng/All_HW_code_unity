using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class MoveRedBall : MonoBehaviour
    {
        public float moveFactor = 0.2f;

        void Start()
        {

        }

        void Update()
        {
            /*..........................the red ball.............................*/

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(moveFactor, 0, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(moveFactor, 0, 0);
            }

            /*......................................................................*/
        }
    }
}
