using UnityEngine;

public class ROTADOR : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotacionY, 0f);
    }
}
