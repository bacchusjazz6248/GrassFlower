using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CStatus : MonoBehaviour
{
	public int hp;
	int hpMax = 500;
	public int mp;
	int mpMax = 100;
    public int upower;
    public int epower;
    public Slider HPslider;
    
	// Use this for initialization
	void Start ()
	{
		hp = hpMax;
		mp = mpMax;
		HPslider.maxValue = hpMax;
		HPslider.value = hpMax;
		upower = 100;
		epower = 40;
	}

	public void OnDamege(int _damege)
	{
		hp -= _damege;
		if (hp <= 0)
		{
			hp = 0;
		}
		HPslider.value = hp;
	}
	
	public void OnHeal()
	{
		hp += 150;
		if (hp >= 500)
		{
			hp = 500;
		}
		HPslider.value = hp;
	}

	public void UseMp(int use)
	{
		mp -= use;
	}

	public void SlimeBite(int _damege)
	{
		hp -= epower * 2;
		if (hp <= 0)
		{
			hp = 0;
		}
		HPslider.value = hp;
	}
}
