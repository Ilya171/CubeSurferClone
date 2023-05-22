using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScr : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private Vector3 newPosition;
    private Vector3 offset;

    [SerializeField] private float lerpValue;



    void Start()
    {
        offset = transform.localPosition - _playerTransform.localPosition;
        
    }

    void LateUpdate()
    {
        SetCameraFollow();

    }

    private void SetCameraFollow()
    {        
        newPosition = Vector3.Lerp(transform.localPosition, new Vector3(0f, 0f, _playerTransform.localPosition.z) + offset, lerpValue * Time.deltaTime);
        transform.localPosition = newPosition;
    }
   
}
