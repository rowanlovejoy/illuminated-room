using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]
    float m_sphereRad = 10.0f;
    [SerializeField]
    float m_maxInteractDist = 50.0f;
    [SerializeField]
    LayerMask m_interactLayers;

    RaycastHit m_hit;

    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (Physics.SphereCast(gameObject.transform.position, m_sphereRad, transform.forward, out m_hit, m_interactLayers))
            {
                Debug.Log("Hit");
            }

            // Check contents of hit, use interface to interact
        }
    }
}
