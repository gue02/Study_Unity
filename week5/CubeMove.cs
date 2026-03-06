using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("게임 시작");
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
