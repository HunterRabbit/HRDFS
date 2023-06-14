using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class DB : ScriptableObject
{
	public List<DialogDBEntity> Entities; // Replace 'EntityType' to an actual type that is serializable.
	public List<DialogDBEntity> Naration;
	//==========솔라오로스================================================================================
	public List<DialogDBEntity> LeeSidol; //솔라오로스 여관 이씨돌 0
	public List<DialogDBEntity> Misrica; //솔라오로스 성당 교황 0
	public List<DialogDBEntity> Zoa; //솔라오로스 성당 일반 사제 0
	public List<DialogDBEntity> Nabita; //솔라오로스 성당 2등 성기사 0
	public List<DialogDBEntity> Liam;   //솔라오로스 광장 음유시인 0
	public List<DialogDBEntity> Beris;  //솔라오로스 왕성 기사단장 0
	public List<DialogDBEntity> Baekdu;  //솔라오로스 왕성 명예귀족 
	public List<DialogDBEntity> Nejin;  //솔라오로스 왕성 명예귀족 0
	public List<DialogDBEntity> Plume; //솔라오로스 왕성 명예귀족
	public List<DialogDBEntity> Yohan;  //솔라오로스 광장 상점주인 0
	public List<DialogDBEntity> Alpha;  //솔라오로스 길드 마스터 0
	public List<DialogDBEntity> Check;  //솔라오로스 도서관 사서 0
	public List<DialogDBEntity> Wardan; //솔라오로스 워단
	public List<DialogDBEntity> Pupu; //솔라오로스 성당 1등 성기사
	public List<DialogDBEntity> Turboki; //솔라오로스 광장 할머니
	public List<DialogDBEntity> Hammer; //솔라오로스 대장장이
	public List<DialogDBEntity> Ugg; //솔라오로스 성당 친절한 사제
	public List<DialogDBEntity> Jakeman; //솔라오로스 서커스 단장
	public List<DialogDBEntity> Garubi; //솔라오로스 미식가 귀족
	public List<DialogDBEntity> Song; //솔라오로스 길드접수원
	//===========세타르==========================================================================================
	public List<DialogDBEntity> Bingo;  //세타르 여관 주인 0
	public List<DialogDBEntity> Benny;  //세타르 상점 주인 0
	public List<DialogDBEntity> Pilaf;  //세타르 투기장 안내인
	public List<DialogDBEntity> Drawf;  //세타르 천재 검투사
	public List<DialogDBEntity> Asinika;  //세타르 대사제
	public List<DialogDBEntity> Moden; //세타르 대장장이
	public List<DialogDBEntity> Kim; //세타르 길드접수원
	public List<DialogDBEntity> Evera; //세타르 마부
	public List<DialogDBEntity> Monkid; //세타르 음유시인
	//===========두르칸==========================================================================================
	public List<DialogDBEntity> Yagnida;    //두르칸 야그니다
	public List<DialogDBEntity> Bejerk;    //두르칸 비저크
	public List<DialogDBEntity> Jeffs;      //두르칸 제프스
	public List<DialogDBEntity> Norjimang;  //두르칸 노르지망
	public List<DialogDBEntity> Jollim;  //두르칸 여관주인
	public List<DialogDBEntity> Boke;  //두르칸 성당 사제
	public List<DialogDBEntity> Naksi;  //두르칸 낚시꾼
	public List<DialogDBEntity> Kang;  //두르칸 길드접수원
	//===========제랄==========================================================================================
	public List<DialogDBEntity> Codelia;  //블루드래곤 코델리아
	public List<DialogDBEntity> Halate;  //대마법사 할라테
	public List<DialogDBEntity> Kachanta;   //뱀파이어 시조 카찬타
	public List<DialogDBEntity> Human;   //뱀파이어 휴만
	//===========기타===========================================================================================
	public List<DialogDBEntity> Elmona;   //리톨치드 신궁
	public List<DialogDBEntity> Abyss;   //심연에 닿은자
	public List<DialogDBEntity> Bite; //바이트 골디투스 레지스탕스 리더
	public List<DialogDBEntity> Senna; //세나 존 레지스탕스 신입
	public List<DialogDBEntity> Sangin; //암시장 상인
	public List<DialogDBEntity> Dobak; //암시장 도박사
	public List<DialogDBEntity> Aria;  //정령왕 아리아
	public List<DialogDBEntity> P; //푸르아라 P-158
	public List<DialogDBEntity> Supia; //나의 정령 수피아
	public List<DialogDBEntity> Fanzy; //호위 털복숭이 팬지
	public List<DialogDBEntity> Fieta; //호위 화화 피엣타
	public List<DialogDBEntity> Ryef; //호위 늙은늑대 르예프
	public List<DialogDBEntity> German; //호위 뉴비 게르만
	public List<DialogDBEntity> Nisasa; //호위 붉은칼날 니사사
	public List<DialogDBEntity> Anomela; //호위 철권 아노멜라
	public List<DialogDBEntity> Aspinel; //서큐버스 아스피넬
	public List<DialogDBEntity> Bamin; //호위 열정의 바민서
	public List<DialogDBEntity> Gimu; //호위 무념무상 기무사무
	public List<DialogDBEntity> Jinujan; //호위 말년 지누잔
    //===========시스템==========================================================================================
	public List<DialogDBEntity> REvent; //랜덤 이벤트
	public List<DialogDBEntity> Ending_A_K; //엔딩 아스피넬 왕 루트
	public List<DialogDBEntity> Ending_A_P; //엔딩 아스피넬 교황 루트
	public List<DialogDBEntity> Ending_Supia; //엔딩 수피아 정령 여론 루트
	public List<DialogDBEntity> Ending_Nuclear; //엔딩 핵미사일 루트
	public List<DialogDBEntity> Ending_Raid; //엔딩 레이드 루트
	public List<DialogDBEntity> Ending_Pinkdoor; //엔딩 제외 루트
}
