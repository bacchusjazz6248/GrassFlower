using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
	public CStatus player;
	public CStatus enemy;
	bool IsPlayerTurn;
	private GameObject gameobj;
	private Animator anim;
	Quaternion q = Quaternion.Euler(0f, 0f, 0f);
	private Transform trans;
	float c_time = 0.0f;
	
	// Use this for initialization
	void Start () {
		gameobj = GameObject.Find("unitychan_dynamic");
		anim = gameobj.GetComponent<Animator>();
		trans = gameobj.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		System.Random r = new System.Random(1000);
		if (!IsPlayerTurn)
		{
			if (r.Next(1) == 0)
			{
				player.OnDamege(enemy.epower);
				
			}
			else
			{
				player.SlimeBite(enemy.epower);
			}
		}
	}

	public void OnAttackButton()
	{
		anim.SetBool("Attack", true);
		trans.SetPositionAndRotation(new Vector3(50,0,30), q);
		enemy.OnDamege(player.upower);
		while (c_time < 2.0f)
		{
			c_time += Time.deltaTime;
		}
		c_time = 0.0f;
		IsPlayerTurn = false;
	}
	
	public void OnFireButton()
	{
		if (player.mp < 30)
		{
			Debug.Log("MP不足！");
			IsPlayerTurn = false;
		}
		else
		{
			player.UseMp(30);
			anim.SetBool("Attack", true);
			trans.SetPositionAndRotation(new Vector3(50,0,30), q);
			enemy.OnDamege(player.upower*3);
			while (c_time < 2.0f)
			{
				c_time += Time.deltaTime;
			}
			c_time = 0.0f;
			IsPlayerTurn = false;
		}
	}
	
	public void OnHealButton()
	{
		if (player.mp < 30)
		{
			Debug.Log("MP不足！");
			IsPlayerTurn = false;
		}
		else
		{
			player.UseMp(15);
			anim.SetBool("Heal", true);
			trans.SetPositionAndRotation(new Vector3(50,0,30), q);
			player.OnHeal();
			while (c_time < 2.0f)
			{
				c_time += Time.deltaTime;
			}
			c_time = 0.0f;
			IsPlayerTurn = false;
		}
	}
}
