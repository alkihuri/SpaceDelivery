using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shaders
{
    public class UniversalShaderAdjuster : MonoBehaviour
    {
        private const int MAX_VALUE = 50;
        [SerializeField, Range(0, MAX_VALUE)] private float _value;
        [SerializeField] private string _key;
        [SerializeField] private Renderer _renderer;
        [SerializeField] private int _materialSequence;
        private void Start()
        {
            Debug.Log(_renderer.materials[_materialSequence].name);
        }
        public void SetUpValue(float value)
        {
            _value = Mathf.Clamp(value, 0, MAX_VALUE);
            ApplyValue();
        }
        private void ApplyValue()
        {
            _renderer.materials[_materialSequence].SetColor(_key, Color.yellow * _value);
        }
    }
}