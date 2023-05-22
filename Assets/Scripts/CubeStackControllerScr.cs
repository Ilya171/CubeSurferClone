using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackControllerScr : MonoBehaviour
{
    public List<GameObject> cubeList = new List<GameObject>();
    private GameObject lastCubeObject;

    private float _hightBetweenCube = 1f;

    private void Start()
    {
        SetLastCubeObject();
    }

    public void AddNewCube(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+_hightBetweenCube,transform.position.z);
        _gameObject.transform.position = new Vector3(transform.position.x,lastCubeObject.transform.position.y-_hightBetweenCube,transform.position.z);
        _gameObject.transform.SetParent(transform);
        cubeList.Add(_gameObject);
        SetLastCubeObject();
    }

    public void DeleteCube(GameObject _gameObject)
    {
        _gameObject.transform.parent= null;
        cubeList.Remove(_gameObject);
        SetLastCubeObject();
        Destroy(_gameObject,1.5f);
    }

    public void SetLastCubeObject()
    {
        lastCubeObject = cubeList[cubeList.Count-1];
    }
    
}

