using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControllerScr : MonoBehaviour
{
    [SerializeField] private CubeStackControllerScr _cubeStackController;
  
    private bool _isStack = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CubeScr>(out CubeScr cube))
        {
            if(!_isStack)
            {
                _isStack = !_isStack;
                _cubeStackController.AddNewCube(gameObject);               
            }
        }
        if (other.TryGetComponent<WallScr>(out WallScr wall))
        {
            _cubeStackController.DeleteCube(gameObject);
        }
    }  
}
