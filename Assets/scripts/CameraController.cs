using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]

public class CameraController : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 0f;
    Player _inputController = null;

    void Awake(){

        _inputController = GetComponent<Player>();
    }

    void Update(){
        MouseCamera();

    }

    void MouseCamera(){

        Vector2 input = _inputController.MouseInput();

        transform.Rotate(Vector3.up* input.x *_mouseSensitivity* Time.deltatime);
    }
}
