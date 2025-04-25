using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class Player : NetworkBehaviour
{
    [SerializeField]
    float _speed;

    private float _horizontalInput;

    // Update is called once per frame
    void Update()
    {
        if (!HasStateAuthority)
            return;

        _horizontalInput = Input.GetAxis("Horizontal");
    }

    public override void FixedUpdateNetwork()
    {
        transform.position += transform.forward * (_horizontalInput * _speed * Runner.DeltaTime);
    }
}
