using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour
{
    public GameObject jugador;
    public GameObject referencia;
    private Vector3 distancia;


void Start () {
        distancia = transform.position - jugador.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }


void LateUpdate () {
    distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
    transform.position = jugador.transform.position +distancia;
    transform.LookAt (jugador.transform.position);

    Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
    referencia.transform.eulerAngles= copiaRotacion;

}
}
