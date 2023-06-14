using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private GameObject[] SE;

    //효과음
    public AudioClip audiopukjjik;  //찌르는 소리
    public AudioClip audiostone;    //돌 굴러가는 소리, 달그락
    public AudioClip absurd;    //황당해하는 소리
    public AudioClip bone_break_fold;   //뼈가 부서지고 접히는 소리
    public AudioClip bone_fold; //뼈가 접히는 소리
    public AudioClip charge;    //전투 전 함성소리
    public AudioClip codelia_howling;   //코델리아 울음소리
    public AudioClip door_open_churc;   //성당 나무문 열리는 소리
    public AudioClip explosion1;    //폭발 1
    public AudioClip explosion2;    //폭발 2
    public AudioClip explosion3;    //폭발 3
    public AudioClip explosion4;    //폭발 4
    public AudioClip Galrumgak1;    //아스피넬 교황 루트 중 갈럼객 등장 소리
    public AudioClip Galrumgak2;    //아스피넬 교황 루트 중 갈럼객 퇴장 소리
    public AudioClip glass_break;   //유리 깨지는 소리 또는 칼 부서지는 소리
    public AudioClip gugugugu;      //땅이 진동하는 소리
    public AudioClip heavy_punch;   //무거운 펀치
    public AudioClip knock_off;     //털썩 쓰러지는 소리
    public AudioClip magic_heal;    //치유 마법 사용하는 소리
    public AudioClip magic_sharara; //마법 샤라라 하는 소리, 기억을 읽거나 그럴때
    public AudioClip magic_wind;    //바람 마법 사용하는 소리, 할라테
    public AudioClip monster1;      //마수 1
    public AudioClip monster2;      //마수 2
    public AudioClip monster3;      //마수 3
    public AudioClip mood_dark;     //어두운 분위기
    public AudioClip move_fast;     //고속 이동, 용사
    public AudioClip nuclear_bomb;  //핵폭탄 폭발
    public AudioClip run_aspart;    //아스팔트 위를 전력질주
    public AudioClip shock;         //충격받는 소리
    public AudioClip sword_fight1;  //칼 끼리 부딪히는 소리 1
    public AudioClip sword_fight2;  //칼 끼리 부딪히는 소리 2
    public AudioClip sword_fight3;  //칼 끼리 부딪히는 소리 3
    public AudioClip sword_slash;   //칼로 베는 소리
    public AudioClip warp;          //순간이동하는 소리
    public AudioClip swoosh; //휙하는 소리
    public AudioClip body_punch; //때리는 소리
    public AudioClip animal_growl; //으르렁 소리
    public AudioClip metal_crash; //땡그랑, 짤랑 하는 소리
    public AudioClip knuckle_crack; //뼈 뽀드득 하는 소리
    public AudioClip walking1; //비포장길 터벅터벅 걷는 소리
    public AudioClip walking2; //콘크리트 바닥 걷는 소리
    public AudioClip cry1; //병사들 함성소리
    public AudioClip electricity; //전기 지지직 소리
    public AudioClip nuclear_button;    //핵엔딩 버튼 누르는 소리
    public AudioClip putdown;   //무언가 내려놓는 소리
    public AudioClip nuclear_alram; //핵 경보
    public AudioClip big_city; //대도시 효과음
    public AudioClip close_door; //문 닫는 소리

    AudioSource audioSource;

    void Awake()
    {
        SE = GameObject.FindGameObjectsWithTag("SE");
        if(SE.Length>=2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    //효과음
    public void PlaySound(string action)
    {
        audioSource.Stop();
        switch (action)
        {
            case "Pukjjik":
                audioSource.clip = audiopukjjik;
                break;
            case "Stone":
                audioSource.clip = audiostone;
                break;
            case "Absurd":
                audioSource.clip = absurd;
                break;
            case "Bone_break_fold":
                audioSource.clip = bone_break_fold;
                break;
            case "Bone_fold":
                audioSource.clip = bone_fold;
                break;
            case "Charge":
                audioSource.clip = charge;
                break;
            case "Codelia_howling":
                audioSource.clip = codelia_howling;
                break;
            case "Door_open_church":
                audioSource.clip = door_open_churc;
                break;
            case "Explosion1":
                audioSource.clip = explosion1;
                break;
            case "Explosion2":
                audioSource.clip = explosion2;
                break;
            case "Explosion3":
                audioSource.clip = explosion3;
                break;
            case "Explosion4":
                audioSource.clip = explosion4;
                break;
            case "Galrumgak1":
                audioSource.clip = Galrumgak1;
                break;
            case "Galrumgak2":
                audioSource.clip = Galrumgak2;
                break;
            case "Glass_break":
                audioSource.clip = glass_break;
                break;
            case "Gugugugu":
                audioSource.clip = gugugugu;
                break;
            case "Heavy_punch":
                audioSource.clip = heavy_punch;
                break;
            case "Knock_off":
                audioSource.clip = knock_off;
                break;
            case "Magic_heal":
                audioSource.clip = magic_heal;
                break;
            case "Magic_sharara":
                audioSource.clip = magic_sharara;
                break;
            case "Magic_wind":
                audioSource.clip = magic_wind;
                break;
            case "Monster1":
                audioSource.clip = monster1;
                break;
            case "Monster2":
                audioSource.clip = monster2;
                break;
            case "Monster3":
                audioSource.clip = monster3;
                break;
            case "Mood_dark":
                audioSource.clip = mood_dark;
                break;
            case "Move_fast":
                audioSource.clip = move_fast;
                break;
            case "Nuclear_bomb":
                audioSource.clip = nuclear_bomb;
                break;
            case "Run_aspart":
                audioSource.clip = run_aspart;
                break;
            case "Shock":
                audioSource.clip = shock;
                break;
            case "Sword_fight1":
                audioSource.clip = sword_fight1;
                break;
            case "Sword_fight2":
                audioSource.clip = sword_fight2;
                break;
            case "Sword_fight3":
                audioSource.clip = sword_fight3;
                break;
            case "Sword_slash":
                audioSource.clip = sword_slash;
                break;
            case "Warp":
                audioSource.clip = warp;
                break;
            case "Swoosh":
                audioSource.clip = swoosh;
                break;
            case "Body_punch":
                audioSource.clip = body_punch;
                break;
            case "Animal_growl":
                audioSource.clip = animal_growl;
                break;
            case "Metal_crash":
                audioSource.clip = metal_crash;
                break;
            case "Knuckle_crack":
                audioSource.clip = knuckle_crack;
                break;
            case "Walking1":
                audioSource.clip = walking1;
                break;
            case "Walking2":
                audioSource.clip = walking2;
                break;
            case "Cry1":
                audioSource.clip = cry1;
                break;
            case "Electricity":
                audioSource.clip = electricity;
                break;
            case "Nucelar_Button":
                audioSource.clip = nuclear_button;
                break;
            case "Putdown":
                audioSource.clip = putdown;
                break;
            case "Nuclear_Alarm":
                audioSource.clip = nuclear_alram;
                break;
            case "Big_City":
                audioSource.clip = big_city;
                break;
            case "Close_Door":
                audioSource.clip = close_door;
                break;
        }
        audioSource.PlayOneShot(audioSource.clip);
    }

}
