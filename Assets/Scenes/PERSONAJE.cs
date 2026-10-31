using UnityEngine;

public class MOVER : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //enteros -- int
    //decimales -- float(f)

    public float velocidad = 0.02f;
    //AND --> &&
    //OR --> || |||| AltGr+1(encima de la Q)
    //NOT --> !
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocidad;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocidad;
        }
    }
}
