using UnityEngine;
public class Selfdestruct : MonoBehaviour
{
    [SerializeField] float time;
    void Start()
    {
        Destroy(gameObject, time);
    }
}
