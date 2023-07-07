using UnityEngine;

namespace Poached.Gameplay
{
public class Zoomies : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 90f);
    }
}
}
