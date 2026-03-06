using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //D키를 입력 감지. 누르는 동안 우측으로 이동
            transform.Translate(Vector3.right * Time.deltaTime * 5);

        if (Input.GetKey(KeyCode.A))//A키를 입력 감지. 누르는 동안 좌측으로 이동
            transform.Translate(Vector3.left * Time.deltaTime * 5);

        if (Input.GetKey(KeyCode.W))//W키를 입력 감지. 누르는 동안 앞쪽으로 이동
            transform.Translate(Vector3.forward * Time.deltaTime * 5);

        if (Input.GetKey(KeyCode.S))//S키를 입력 감지. 누르는 동안 뒤쪽으로 이동
            transform.Translate(Vector3.back * Time.deltaTime * 5);
    }
}
