using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
	public CStatus player;
	public CStatus enemy;
	bool IsPlayerTurn;
	
	// Use this for initialization
	void Start () {
		
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
		enemy.OnDamege(player.upower);
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
			enemy.OnDamege(player.upower*3);
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
			player.OnHeal();
			IsPlayerTurn = false;
		}
	}
}
