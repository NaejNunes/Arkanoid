using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    public Color[] damageColor;

    int maxHits;
    protected int hitNumbers;

    // Start is called before the first frame update
    void Start()
    {
        hitNumbers = 0;
        maxHits = damageColor.Length;
        GetComponent<SpriteRenderer>().color = damageColor[hitNumbers];
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hitNumbers++;
        if (hitNumbers == maxHits)
            Destroy(gameObject);
        else
            GetComponent<SpriteRenderer>().color = damageColor[hitNumbers];
    }
}
