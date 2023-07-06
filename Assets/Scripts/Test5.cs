using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    CubismModel model;

    private void Start()
    {
        model = GameObject.Find("mao_pro_t02").GetComponent<CubismModel>();
    }

    private void LateUpdate()
    {
        model.Parameters[0].Value = 30;
        //model.Parameters.FindById("角度 X").Value = 30;
    }
}




public class A
{
    // Aの処理
}

public class B : A
{
    // Bの処理
}