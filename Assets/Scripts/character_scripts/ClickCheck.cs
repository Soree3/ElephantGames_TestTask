using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCheck : MonoBehaviour
{
    [SerializeField] private GameObject zombie;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.GetComponent<ZombieRun>() == null)
            {
                zombie.GetComponent<ZombieRun>().startRunning = true;
                Debug.Log(hit.collider.name);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
