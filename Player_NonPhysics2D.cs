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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
