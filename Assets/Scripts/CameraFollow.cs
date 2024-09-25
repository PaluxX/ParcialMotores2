using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    public float smoothSpeed;

    private void LateUpdate()
    {
        Vector3 desiredPosition = Player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition , smoothSpeed * Time.deltaTime );

        transform.position = smoothedPosition;

        //transform.LookAt(Player);
    }
}
