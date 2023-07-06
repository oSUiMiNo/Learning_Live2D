using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    Test1 test1;
    private void Start()
    {
        test1 = GameObject.Find("パラメータ取得のテスト1").GetComponent<Test1>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) test1.a = 0;
        if (Input.GetKeyDown(KeyCode.Alpha5)) test1.a = 5;
        if (Input.GetKeyDown(KeyCode.Alpha9)) test1.a = 9;
    }
}
