using System;
using UnityEngine;

public class CraftPotion : MonoBehaviour
{
    public Renderer potionRenderer;
    private Color color;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (potionRenderer != null)
        {
            potionRenderer.material.color = new Color(0, 0, 0);
            color = potionRenderer.material.color;
        }
        else
        {
            color = new Color(0, 0, 0);
        }
    }

    public void ChangeR(float x)
    {
        color.r = Mathf.Clamp01(color.r + x);
        potionRenderer.material.color = color;
    }

    public void ChangeG(float x)
    {
        color.g = Mathf.Clamp01(color.g + x);
        potionRenderer.material.color = color;
    }

    public void ChangeB(float x)
    {
        color.b = Mathf.Clamp01(color.b + x);
        potionRenderer.material.color = color;
    }
}
