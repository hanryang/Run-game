using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_NonPhysics2D : MonoBehaviour
{
    // -----선언-------------------------------------------

    // Inspector
    public float speed = 15.0f; // 플레이어 캐릭터의 속도
    public Sprite[] run; // 플레이어 캐릭터의 달리기 스프라이트
    public Sprite[] jump; // 플레이어 캐릭터의 점프 스프라이트

    // 내부에서 다루는 변수
    float jumpVy; // 플레이어 캐릭터의 상승 속도
    int anumIndex; // 플레이어 캐릭터 애니메이션 재생 인덱스
    bool goalCheck; // 골인했는지 체크
    // Start is called before the first frame update
    void Start()
    {
        //초기화
        jumpVy = 0.0f;
        animIndex = 0;
        goalCheck = false;
    }

    // 플레이어 캐릭터에 적용된 충돌 판정 영역에 다른 게임 오브젝트의 충돌 판정 영역이 겹쳤다
    void OncollisionEnter2D(Coollision2D col)
    {
        // 들어왔는지 검사
        if (col.gameObject.name == "Stage_Gate")
        {
            //들어왔다
            goalCheck = true;
            return;
        }
        // 골인 지점이 아닌 곳이라면 스테이지를 다시 로드해서 초기화한다.
        Application.LoadLevel(Application.loadedLevelName);
    }
    // 프레임 다시 쓰기
    // Update is called once per frame
    void Update()
    {
        // 들어왔는지 검사
        if (goalCheck)
        {
            return; //들어왔다면 처리를 멈춘다.
        }

        // 현재 플레이어 캐릭터가 어느 높이에 있는지 계산
        float height = transform.position.y + jumpVy;
        // 접지 확인(높이가 0이면 접지한 것임)
        if (height <= 0.0f)
        {
            // 점프 초기화
            height = 0.0f;
            jumpVy = 0.0f;

            // 점프 확인
            if (Input.GetButtonDown("Fire1"))
            {
                // 점프 처리
                jumpVy = +1.3f;
            }
        }
    }
}
