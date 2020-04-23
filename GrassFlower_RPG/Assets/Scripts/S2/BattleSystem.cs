using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
	public CStatus player;
	public CStatus enemy;
	bool IsPlayerTurn = true;
	bool IsPlayerGameOver = false;
	bool IsMonsterGameOver = false;
	private GameObject gameobj;
	private Animator anim;
	private GameObject sgameobj;
	private Animator sanim;
	Quaternion q = Quaternion.Euler(0f, 0f, 0f);
	private Transform trans;
	float c_time = 0.0f;
	public GameObject ResultPanel;
	public GameObject ResultWinPanel;
	
	// Use this for initialization
	void Start () {
		gameobj = GameObject.Find("unitychan_dynamic");
		anim = gameobj.GetComponent<Animator>();
		sgameobj = GameObject.Find("Slime_Green");
		sanim = sgameobj.GetComponent<Animator>();
		trans = gameobj.GetComponent<Transform>();
		ResultPanel.SetActive(false);
		ResultWinPanel.SetActive(false);
	}

	void ViewResult()
	{
		ResultPanel.SetActive(true);
	}
	
	void ViewWinResult()
	{
		ResultWinPanel.SetActive(true);
	}

	private float second = 0f;
	
	// Update is called once per frame
	void Update () {
		if (IsPlayerGameOver)
		{
			ViewResult();
			return;
		}
		
		if (IsMonsterGameOver)
		{
			second += Time.deltaTime;
			if (second >= 3.0f)
			{
				ViewWinResult();
				return;
			}
		}
		
		System.Random r = new System.Random(1000);
		if (!IsPlayerTurn)
		{
			second += Time.deltaTime;
			if (second >= 1.0f)
			{
				if (r.Next(2) == 0)
				{
					sanim.SetBool("Attack", true);
					player.OnDamege(enemy.epower);
					second = 0f;
					IsPlayerTurn = true;

				}
				else
				{
					sanim.SetBool("Attack", true);
					player.SlimeBite(enemy.epower);
					IsPlayerTurn = true;
				}
			}
			
			if(player.hp == 0){
				IsPlayerGameOver = true;
			}
		}
	}

	public void OnAttackButton()
	{
		anim.SetBool("Attack", true);
		trans.SetPositionAndRotation(new Vector3(50,0,30), q);
		enemy.OnDamege(player.upower);
		if(enemy.hp == 0)
		{
			sanim.SetBool("Die", true);
			IsMonsterGameOver = true;
		}
		IsPlayerTurn = false;
	}
	
	public void OnFireButton()
	{
		if (player.mp < 30)
		{
			Debug.Log("MP不足！");
		}
		else
		{
			player.UseMp(30);
			anim.SetBool("Attack", true);
			trans.SetPositionAndRotation(new Vector3(50,0,30), q);
			enemy.OnDamege(player.upower*3);
			if(enemy.hp == 0)
			{
				sanim.SetBool("Die", true);
				IsMonsterGameOver = true;
			}
			IsPlayerTurn = false;
		}
	}
	
	public void OnHealButton()
	{
		if (player.mp < 30)
		{
			Debug.Log("MP不足！");
		}
		else
		{
			player.UseMp(15);
			anim.SetBool("Heal", true);
			trans.SetPositionAndRotation(new Vector3(50,0,30), q);
			player.OnHeal();
			IsPlayerTurn = false;
		}
	}
}
