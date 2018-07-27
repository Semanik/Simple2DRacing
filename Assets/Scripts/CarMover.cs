using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CarMover : MonoBehaviour {

    public Transform SelfTransform;
    public Tilemap Map;
    public TileBase GroundTile;
    public float Speed;

    private Vector3 _force;
    private bool _isAccelerated;

    public float GetForce()
    {
        return _force.magnitude;
    }

	public void Accelerate()
    {
        _force += (SelfTransform.up * Time.deltaTime) * 0.1f;
        _isAccelerated = true;
    }

    public void RotateRight()
    {
        SelfTransform.Rotate(0, 0, -1);
    }

    public void RotateLeft()
    {
        SelfTransform.Rotate(0, 0, 1);
    }

	void LateUpdate ()
    {
        if (!_isAccelerated)
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        if(GroundTile == Map.GetTile(Map.WorldToCell(SelfTransform.position)))
        {
            _force *= 0.9f;
        }

        SelfTransform.position += _force * Speed * Time.deltaTime;
        

        _isAccelerated = false;
    }
}
