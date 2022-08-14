using Shaders;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sahders
{
    public class ValueMapper : MonoBehaviour
    {

        [SerializeField] private Rigidbody _rBody;
        [SerializeField] UniversalShaderAdjuster _adjuster;
        private void Awake()
        {
            Cashing();
        }

        private void Cashing()
        {
            _adjuster = GetComponent<UniversalShaderAdjuster>();
        }
        private void Update()
        {
            _adjuster.SetUpValue(_rBody.velocity.magnitude * 10);
        }
    }
}