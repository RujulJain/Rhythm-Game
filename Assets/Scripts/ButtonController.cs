using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            _spriteRenderer.sprite = pressedImage;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            _spriteRenderer.sprite = defaultImage;
        }
    }
}
