using System;
using UnityEngine;

public class CraftPotion : MonoBehaviour
{
    public Renderer potionRenderer;
    private Color color;
    
    void Start()
    {
        if (potionRenderer != null)
        {
            color = potionRenderer.material.color;
        }
        else
        {
            color = new Color(0, 0, 0);
        }
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    ChangeR(.1f);
        //}
        //
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    ChangeR(-.1f);
        //    
        //}        
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    ChangeG(.1f);
        //}
        //
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    ChangeG(-.1f);
        //    
        //}        
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    ChangeB(.1f);
        //}
        //
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    ChangeB(-.1f);
        //    
        //}        

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
