using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequiredComponent(typeof(Player))]
public class MyCamera : MonoBehaviour
{
   
    [SerializeField] float _mouseSensitivity = 0f;
    Player _inputController = null;

    void Awake(){

        _inputController = GetComponent<Player>();
    }

    void Update(){


    }

    void MouseCamera(){

        vector2 input = _inputController.MouseInput();

        transform.Rotate(Vector3.up* input.x *_mouseSensitivity* Time.deltatime);
    }

}