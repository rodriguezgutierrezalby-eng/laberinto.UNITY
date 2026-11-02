using UnityEngine;

public class DetectorMetaFalsa : MonoBehaviour
{
    [SerializeField]
    GameObject MetaFalsa;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("¡Caaasi! Bueno, en realidad ni te acercaste. De vuelta al inicio");
            MetaFalsa.SetActive(true);
            other.GetComponent<MOVER>().enabled = false;
        }
    }
}