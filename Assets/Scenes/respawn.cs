using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject puntito;

private void Update()
    {
       if (transform.position.y < 0f)
        {
            transform.position = puntito.transform.position;
        }
    }
}
