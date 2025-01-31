using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class MoveYallowBall : MonoBehaviour
    {
        public float moveFactor = 0.2f;

        void Start()
        {

        }

        void Update()
        {
             /*..........................the yallow ball.............................*/

            if (Input.GetKey(KeyCode.Keypad6))
            {
                transform.position += new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.Keypad4))
            {
                transform.position -= new Vector3(0, 0, moveFactor);
            }

            if (Input.GetKey(KeyCode.Keypad8))
            {
                transform.position += new Vector3(moveFactor, 0, 0);
            }

            if (Input.GetKey(KeyCode.Keypad2))
            {
                transform.position -= new Vector3(moveFactor, 0, 0);
            }

            /*......................................................................*/
        }
    }
}
