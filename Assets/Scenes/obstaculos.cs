using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public Material materialEncendido;
    public Material materialApagado;
    bool encendido = false;
    float cronometro = 5f;
    //variable = 3; Numero == 4
    //Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Update()
    {
        if (encendido)
        {
            cronometro = cronometro - Time.deltaTime;
            print(cronometro);
            if (cronometro < 0f)
            {
                encendido = false;
                GetComponent<MeshRenderer>().material = materialApagado;
                cronometro = 2f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = materialEncendido;
        encendido = true;
    }
}
    


