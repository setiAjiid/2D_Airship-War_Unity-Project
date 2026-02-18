using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private float speedBg = 3;

    private float moveX;
    private float widthBg;
    private Sprite sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        widthBg = sprite.texture.width / sprite.pixelsPerUnit;
        Debug.Log(widthBg);

    }

    // Update is called once per frame
    void Update()
    {
        moveX = speedBg * Time.deltaTime;
        transform.position += new Vector3(moveX, 0f, 0f);

        if (Mathf.Abs(transform.position.x) > widthBg)
        {
            transform.position = new Vector3(0f, transform.position.y);
        }
    }
}
