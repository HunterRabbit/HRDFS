using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class DB : ScriptableObject
{
	public List<DialogDBEntity> Entities; // Replace 'EntityType' to an actual type that is serializable.
	public List<DialogDBEntity> Naration;
	//==========�ֶ���ν�================================================================================
	public List<DialogDBEntity> LeeSidol; //�ֶ���ν� ���� �̾��� 0
	public List<DialogDBEntity> Misrica; //�ֶ���ν� ���� ��Ȳ 0
	public List<DialogDBEntity> Zoa; //�ֶ���ν� ���� �Ϲ� ���� 0
	public List<DialogDBEntity> Nabita; //�ֶ���ν� ���� 2�� ����� 0
	public List<DialogDBEntity> Liam;   //�ֶ���ν� ���� �������� 0
	public List<DialogDBEntity> Beris;  //�ֶ���ν� �ռ� ������ 0
	public List<DialogDBEntity> Baekdu;  //�ֶ���ν� �ռ� ������ 
	public List<DialogDBEntity> Nejin;  //�ֶ���ν� �ռ� ������ 0
	public List<DialogDBEntity> Plume; //�ֶ���ν� �ռ� ������
	public List<DialogDBEntity> Yohan;  //�ֶ���ν� ���� �������� 0
	public List<DialogDBEntity> Alpha;  //�ֶ���ν� ��� ������ 0
	public List<DialogDBEntity> Check;  //�ֶ���ν� ������ �缭 0
	public List<DialogDBEntity> Wardan; //�ֶ���ν� ����
	public List<DialogDBEntity> Pupu; //�ֶ���ν� ���� 1�� �����
	public List<DialogDBEntity> Turboki; //�ֶ���ν� ���� �ҸӴ�
	public List<DialogDBEntity> Hammer; //�ֶ���ν� ��������
	public List<DialogDBEntity> Ugg; //�ֶ���ν� ���� ģ���� ����
	public List<DialogDBEntity> Jakeman; //�ֶ���ν� ��Ŀ�� ����
	public List<DialogDBEntity> Garubi; //�ֶ���ν� �̽İ� ����
	public List<DialogDBEntity> Song; //�ֶ���ν� ���������
	//===========��Ÿ��==========================================================================================
	public List<DialogDBEntity> Bingo;  //��Ÿ�� ���� ���� 0
	public List<DialogDBEntity> Benny;  //��Ÿ�� ���� ���� 0
	public List<DialogDBEntity> Pilaf;  //��Ÿ�� ������ �ȳ���
	public List<DialogDBEntity> Drawf;  //��Ÿ�� õ�� ������
	public List<DialogDBEntity> Asinika;  //��Ÿ�� �����
	public List<DialogDBEntity> Moden; //��Ÿ�� ��������
	public List<DialogDBEntity> Kim; //��Ÿ�� ���������
	public List<DialogDBEntity> Evera; //��Ÿ�� ����
	public List<DialogDBEntity> Monkid; //��Ÿ�� ��������
	//===========�θ�ĭ==========================================================================================
	public List<DialogDBEntity> Yagnida;    //�θ�ĭ �߱״ϴ�
	public List<DialogDBEntity> Bejerk;    //�θ�ĭ ����ũ
	public List<DialogDBEntity> Jeffs;      //�θ�ĭ ������
	public List<DialogDBEntity> Norjimang;  //�θ�ĭ �븣����
	public List<DialogDBEntity> Jollim;  //�θ�ĭ ��������
	public List<DialogDBEntity> Boke;  //�θ�ĭ ���� ����
	public List<DialogDBEntity> Naksi;  //�θ�ĭ ���ò�
	public List<DialogDBEntity> Kang;  //�θ�ĭ ���������
	//===========����==========================================================================================
	public List<DialogDBEntity> Codelia;  //���巡�� �ڵ�����
	public List<DialogDBEntity> Halate;  //�븶���� �Ҷ���
	public List<DialogDBEntity> Kachanta;   //�����̾� ���� ī��Ÿ
	public List<DialogDBEntity> Human;   //�����̾� �޸�
	//===========��Ÿ===========================================================================================
	public List<DialogDBEntity> Elmona;   //����ġ�� �ű�
	public List<DialogDBEntity> Abyss;   //�ɿ��� ������
	public List<DialogDBEntity> Bite; //����Ʈ ������� ���������� ����
	public List<DialogDBEntity> Senna; //���� �� ���������� ����
	public List<DialogDBEntity> Sangin; //�Ͻ��� ����
	public List<DialogDBEntity> Dobak; //�Ͻ��� ���ڻ�
	public List<DialogDBEntity> Aria;  //���ɿ� �Ƹ���
	public List<DialogDBEntity> P; //Ǫ���ƶ� P-158
	public List<DialogDBEntity> Supia; //���� ���� ���Ǿ�
	public List<DialogDBEntity> Fanzy; //ȣ�� �к����� ����
	public List<DialogDBEntity> Fieta; //ȣ�� ȭȭ �ǿ�Ÿ
	public List<DialogDBEntity> Ryef; //ȣ�� �������� ������
	public List<DialogDBEntity> German; //ȣ�� ���� �Ը���
	public List<DialogDBEntity> Nisasa; //ȣ�� ����Į�� �ϻ��
	public List<DialogDBEntity> Anomela; //ȣ�� ö�� �Ƴ���
	public List<DialogDBEntity> Aspinel; //��ť���� �ƽ��ǳ�
	public List<DialogDBEntity> Bamin; //ȣ�� ������ �ٹμ�
	public List<DialogDBEntity> Gimu; //ȣ�� ���乫�� �⹫�繫
	public List<DialogDBEntity> Jinujan; //ȣ�� ���� ������
    //===========�ý���==========================================================================================
	public List<DialogDBEntity> REvent; //���� �̺�Ʈ
	public List<DialogDBEntity> Ending_A_K; //���� �ƽ��ǳ� �� ��Ʈ
	public List<DialogDBEntity> Ending_A_P; //���� �ƽ��ǳ� ��Ȳ ��Ʈ
	public List<DialogDBEntity> Ending_Supia; //���� ���Ǿ� ���� ���� ��Ʈ
	public List<DialogDBEntity> Ending_Nuclear; //���� �ٹ̻��� ��Ʈ
	public List<DialogDBEntity> Ending_Raid; //���� ���̵� ��Ʈ
	public List<DialogDBEntity> Ending_Pinkdoor; //���� ���� ��Ʈ
}
