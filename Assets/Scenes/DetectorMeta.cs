using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
   
    [SerializeField]
    TextMeshProUGUI textlabelTime;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        
        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("jugador llegó a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<MOVER>().enabled = false;
            estaJugando = false;
            textlabelTime.text = tiempoDePartida.ToString();
        }
      
    }
}
