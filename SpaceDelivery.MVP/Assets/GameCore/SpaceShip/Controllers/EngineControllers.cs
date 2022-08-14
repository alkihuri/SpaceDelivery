using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmoShip.Controllers
{
    public class EngineControllers : MonoBehaviour
    {
        private Rigidbody _rBody;
        private float _v, _h;
        [SerializeField, Range(1, 100)] private float _enginePower;

        // Start is called before the first frame update
        void Awake()
        {
            Cashing();
        }

        private void Cashing()
        {
            _rBody = GetComponent<Rigidbody>();
        }

        private void InputDataHandler()
        {
            _v = Input.GetAxis("Vertical");
            _h = Input.GetAxis("Horizontal");
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            InputDataHandler();
            EngineValues();
        }

        private void EngineValues()
        {
            _rBody.AddRelativeForce(transform.forward * _v * _enginePower, ForceMode.Impulse);
            _rBody.AddRelativeTorque(new Vector3(0, _h * _enginePower, 0), ForceMode.Impulse);
        }
    }
}