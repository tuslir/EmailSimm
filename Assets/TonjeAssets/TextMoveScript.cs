using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMoveScript : MonoBehaviour
{

    public Transform startPos, endPos;
    public float speed = 2f;
    public bool atEnd;

    RectTransform rect;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {

        if (!atEnd) transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (atEnd)
        {
            transform.localPosition = startPos.localPosition;
            atEnd = false;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "End")
        {
            atEnd = true;
        }
    }


}
