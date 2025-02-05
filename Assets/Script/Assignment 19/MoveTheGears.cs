using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment19
{
    public class MoveTheGears : MonoBehaviour
    {
        public GameObject[] gears;
        public float degre = 0f;
        public float anglFactor = 2f;
        void Start()
        {

        }

        void Update()
        {
            degre += anglFactor;
            gears[0].transform.rotation = Quaternion.Euler(new Vector3(degre * 5, 90f, -90f));
            gears[1].transform.rotation = Quaternion.Euler(new Vector3(-degre * 3, 90f, -90f));

        }
    }
}
