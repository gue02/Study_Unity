using UnityEngine;

public class CubeMove : MonoBehaviour // MonoBehaviour가 없으면 적용 불가
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //기본적으로 실행시 한번 진행하는 start()
    {
        Debug.Log("게임 시작");
        
    }

    // Update is called once per frame
    void Update() // 지속적으로 해당 함수를 반복하는 Update()
    {   
        transform.Translate(Vector3.up * Time.deltaTime);
        //transform(위치).Translate(위치 변경)(Vector3.up * Time.deltaTime(프레임 당 위치 이동, 앞으로 이동));
    }
}
