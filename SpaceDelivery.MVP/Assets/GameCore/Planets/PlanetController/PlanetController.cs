using CosmoShip.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets
{
    public class PlanetController : MonoBehaviour
    {
        GameObject _player;

        // Start is called before the first frame update
        void Start()
        {
            _player = GameObject.FindObjectOfType<EngineControllers>().gameObject;
            transform.localEulerAngles = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        }

        // Update is called once per frame
        void Update()
        {
            transform.localEulerAngles += new Vector3(0, 1, 0);
            Debug.DrawLine(transform.position, _player.transform.position, Color.yellow, 1);
        }
    }
}