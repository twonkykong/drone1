using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    private Rigidbody _rb;
    private float _yVelocity;

    [SerializeField]
    private float _speed = 10;

    [SerializeField]
    private Transform _droneBody, _camera;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 acc = Input.acceleration * _speed;
        _rb.velocity = new Vector3(acc.x, _yVelocity, acc.y);

        Quaternion nextRot = Quaternion.Euler(acc.y, 0, -acc.x);
        _droneBody.rotation = Quaternion.Slerp(_droneBody.rotation, nextRot, 0.3f);

        Vector3 nextCamPos = transform.position + (transform.up * 26 + transform.forward * -21);
        _camera.position = Vector3.Slerp(_camera.position, nextCamPos, 0.2f);
    }
}
