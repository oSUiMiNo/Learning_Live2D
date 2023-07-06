using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    Test1 test1;

    private void Start()
    {
        test1 = this.gameObject.GetComponent<Test1>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) test1.a = 0;
        if (Input.GetKeyDown(KeyCode.Alpha5)) test1.a = 5;
        if (Input.GetKeyDown(KeyCode.Alpha9)) test1.a = 9;
    }
}