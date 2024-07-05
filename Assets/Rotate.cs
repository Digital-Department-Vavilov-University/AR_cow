
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] public float speed = 30;
    
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
