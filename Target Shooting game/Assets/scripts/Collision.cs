using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public int speed = 25;
    private void Start()
    {
        transform.Translate(Vector3.down * 1 * Time.deltaTime * speed);

    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Debug.Log("Collision Handler (collision)"+collision.gameObject.tag);
        //Debug.Log("Collision Handler (gameObj)"+gameObject.tag);
        if (collision.gameObject.CompareTag("target"))
        {
            ScoreManager.instance.IncreaseScore();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
