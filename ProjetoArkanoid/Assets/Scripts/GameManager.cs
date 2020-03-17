using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI txtPoint;
    public GameObject prefabSpecialItem;
    public GameObject paddle;

    protected int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spownItem", 3);
    }

    protected void spownItem()
    {
        GameObject specialItem = Instantiate(prefabSpecialItem);
        specialItem.transform.position = new Vector2(UnityEngine.Random.Range(-7, 7), UnityEngine.Random.Range(1, -3));
    }

    public void OnBallCollision(GameObject other)
    {
        if (other.CompareTag("TagGameOver"))
        {
            SceneManager.LoadScene(2);
        }
        else if (other.CompareTag("TagSpecialItem"))
        {
            onSpecialItemCollision(other);
        }
        else if (other.CompareTag("TagBrick"))
        {
            AddPoint(100);
        }
    }

    protected void AddPoint(int points)
    {
        score += points;
        txtPoint.text = score.ToString();
    }
    public void onSpecialItemCollision(GameObject other)
    {
        Vector2 size = paddle.GetComponent<SpriteRenderer>().size;
        size.x += 0.5f;

        paddle.GetComponent<SpriteRenderer>().size = size;
        paddle.GetComponent<CapsuleCollider2D>().size = size;

        Destroy(other.gameObject);

        Invoke("spawnItem", 5);
    }
}
