using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_UI_script : MonoBehaviour
{
    [SerializeField] private GameObject button;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.GetComponent<Show_UI_script>() != null)
            {
                button.SetActive(true);
            }
        }
    }
}
