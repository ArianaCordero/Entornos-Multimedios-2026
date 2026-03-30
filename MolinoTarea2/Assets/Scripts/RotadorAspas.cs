using UnityEngine;

public class RotadorAspas : MonoBehaviour
{
    public float velocidadGiro = 90.0f;

    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadGiro * Time.deltaTime);
    }
}