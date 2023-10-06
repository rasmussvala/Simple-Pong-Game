using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public Camera mainCamera;
    public SpriteRenderer spriteRenderer;
    public Color color = Color.blue;

    private Color ogColor;

    // Start is called before the first frame update
    void Start()
    {
        ogColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        // Klickar på vänster musknapp 
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (!hit.collider)
            {
                return;
            }

            if (hit.collider.gameObject == this.gameObject)
            {
                if (spriteRenderer.color == ogColor)
                {
                    spriteRenderer.color = color;
                }
                else
                {
                    spriteRenderer.color = ogColor;
                }
            }
        }
    }
}
