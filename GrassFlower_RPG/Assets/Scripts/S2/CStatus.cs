using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStatus : MonoBehaviour
{
	public int hp;
	int hpMax = 500;
	public int mp;
	int mpMax = 100;
    public int upower;
    public int epower;
    
	// Use this for initialization
	void Start ()
	{
		hp = hpMax;
		mp = mpMax;
		upower = 100;
		epower = 40;
	}

	public void OnDamege(int _damege)
	{
		hp -= _damege;
	}
	
	public void OnHeal()
	{
		hp += 150;
	}

	public void UseMp(int use)
	{
		mp -= use;
	}

	public void SlimeBite(int _damege)
	{
		hp -= epower * 2;
	}
}
