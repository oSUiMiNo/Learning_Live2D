using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework.LookAt;

public class Test8 : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] CubismModel model;
    [SerializeField] CubismLookController lookController;

    private void Update()
    {
        if(model.Parameters[1].Value >= 25)
        {
            lookController.enabled = false;
        }
        else 
        {
            lookController.enabled = true;
        }
    }

    private void LateUpdate()
    {
        model.Parameters[1].Value = slider.value;
    }
}
