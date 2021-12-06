using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    [SerializeField] Texture2D currsor;
    // Start is called before the first frame update

    private void OnMouseEnter()
    {
        Cursor.SetCursor(currsor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
