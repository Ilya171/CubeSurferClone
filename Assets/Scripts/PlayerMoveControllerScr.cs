using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControllerScr : MonoBehaviour
{
    [SerializeField] private float _forwardMoveSpeed;
    [SerializeField] private float _horizontalMoveSpeed;
    [SerializeField] private float _maxHorizontalPosition;

    public bool isCanMove = false;

    private float _horizontalInputValue;    

    private void FixedUpdate()
    {
        GetHorizontalInputValue();
      //  ForwardMove();
        HorizontalMove();
    }
    private void GetHorizontalInputValue()
    {
        if(Input.GetMouseButton(0))
        {
            isCanMove = true;
            _horizontalInputValue = Input.GetAxis("Mouse X");           
        }
        else
        {
            _horizontalInputValue = 0f;
        }
    }
    private void ForwardMove()
    {
        transform.Translate(Vector3.forward * _forwardMoveSpeed*Time.fixedDeltaTime);
    }

    private float _newHorizontalPosition;
    private void HorizontalMove()
    {
        _newHorizontalPosition = transform.localPosition.x + _horizontalInputValue * _horizontalMoveSpeed*Time.fixedDeltaTime;
        _newHorizontalPosition = Mathf.Clamp(_newHorizontalPosition, -_maxHorizontalPosition, _maxHorizontalPosition);
        transform.localPosition = new Vector3(_newHorizontalPosition, transform.localPosition.y, transform.localPosition.z);
       
       
    }
}
