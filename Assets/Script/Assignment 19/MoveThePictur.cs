using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment19
{
    public class MoveThePictur : MonoBehaviour
    {

        public GameObject[] picturs;
        void Start()
        {

        }

        void Update()
        {
            float displacement = 1;
            foreach (GameObject pictur in picturs)
            {
                displacement += 1f;
                float moveX = Mathf.PingPong(Time.time *displacement *1.5f, 7f);
                float yy = pictur.transform.position.y;
                float zz = pictur.transform.position.z;
                pictur.transform.position = new Vector3(moveX , yy, zz);
            }

        }
    }
}
