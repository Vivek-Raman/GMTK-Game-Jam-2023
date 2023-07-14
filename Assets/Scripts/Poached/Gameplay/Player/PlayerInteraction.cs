using System;
using Poached.Gameplay.Character;
using UnityEngine;

namespace GGJ.Poached.Gameplay.Player
{
public class PlayerInteraction : MonoBehaviour
{
    private const float MAX_RAYCAST_DISTANCE = 200f;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonUp(0)) return;

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, MAX_RAYCAST_DISTANCE))
        {
            if (hitInfo.transform.TryGetComponent(out IClickable clickable))
            {
                clickable.OnClicked();
            }

        }
    }
}
}
