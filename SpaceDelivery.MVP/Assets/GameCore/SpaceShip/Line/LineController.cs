using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{

    [SerializeField] GameObject _player;
    public Transform P0;
    public Transform P1;
    public Transform P2;
    public Transform P3;
    [SerializeField] GameObject _goal;
    [SerializeField] LineRenderer _line;
    private List<Vector3> _path = new List<Vector3>();

    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
    }

    public void CalculateDirection()
    {
        int sigmentsNumber = 20;
        _line.positionCount = sigmentsNumber;
        Vector3 preveousePoint = P0.position;
        _path.Clear();
        for (int i = 0; i < sigmentsNumber + 1; i++)
        {
            float paremeter = (float)i / sigmentsNumber;
            Vector3 point = Bezier.GetPoint(P0.position, P1.position, P2.position, P3.position, paremeter);
            Gizmos.color = Color.yellow;
            _path.Add(preveousePoint);
            preveousePoint = point;
        }
        _line.SetPositions(_path.ToArray());


    }
    // Update is called once per frame
    void Update()
    {
        CalculateDirection();
    }
}
