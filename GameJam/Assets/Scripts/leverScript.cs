using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript : MonoBehaviour
{
    public bool value;

    public Sprite newSprite;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print($"Triggered: {value}");
            FlipValue();

            if (newSprite != null)
            {
                spriteRenderer.sprite = newSprite;
            }
        }
    }

    private void FlipValue()
    {
        value = !value;
    }
}
