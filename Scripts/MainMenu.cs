using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public GameObject bg;
	public GameObject gamescreen;
	public GameObject bag_button;
	public GameObject inside_bag;
	public GameObject speed_button;
	public GameObject weapon_bag;
	public GameObject upgrade_bag;
	public GameObject mission_bag;
	public GameObject topUp_bag;
	public GameObject option_bag;
	public GameObject cancel_bag;
	public GameObject ascension_button;
	public GameObject inside_ascension;
	public GameObject level_asc;
	public GameObject point_asc;
	
	public GameObject tab_option_upgrade;
	public GameObject tab_option_achievement;
	public GameObject tab_option_opsi;
	public GameObject tab_option_character;
	

    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(true);
		gamescreen.SetActive(false);
		inside_bag.SetActive(false);
		inside_ascension.SetActive(false);
		
    }
	
	
	public void gamesClicked()
	{
		bg.SetActive(false);
		gamescreen.SetActive(true);
	}
	
	public void ascensionClicked()
	{
		ascension_button.SetActive(true);
		inside_ascension.SetActive(true);
	}
	
	public void asc_levelClicked()
	{
		level_asc.SetActive(true);
		point_asc.SetActive(false);
	}
	
	public void asc_pointClicked()
	{
		level_asc.SetActive(false);
		point_asc.SetActive(true);
	}
	
	public void bagClicked()
	{
		bg.SetActive(false);
		speed_button.SetActive(false);
		inside_bag.SetActive(true);
		bag_button.SetActive(false);
		weapon_bag.SetActive(true);
		upgrade_bag.SetActive(false);
		mission_bag.SetActive(false);
		topUp_bag.SetActive(false);
		option_bag.SetActive(false);
	}
	
	public void weaponClicked()
	{
		weapon_bag.SetActive(true);
		upgrade_bag.SetActive(false);
		mission_bag.SetActive(false);
		topUp_bag.SetActive(false);
		option_bag.SetActive(false);
	}
	
	public void upgradeClicked()
	{
		weapon_bag.SetActive(false);
		upgrade_bag.SetActive(true);
		mission_bag.SetActive(false);
		topUp_bag.SetActive(false);
		option_bag.SetActive(false);
	}
	
	public void missionClicked()
	{
		weapon_bag.SetActive(false);
		upgrade_bag.SetActive(false);
		mission_bag.SetActive(true);
		topUp_bag.SetActive(false);
		option_bag.SetActive(false);
	}
	
	public void top_upClicked()
	{
		weapon_bag.SetActive(false);
		upgrade_bag.SetActive(false);
		mission_bag.SetActive(false);
		topUp_bag.SetActive(true);
		option_bag.SetActive(false);
	}
	
	public void optionClicked()
	{
		weapon_bag.SetActive(false);
		upgrade_bag.SetActive(false);
		mission_bag.SetActive(false);
		topUp_bag.SetActive(false);
		option_bag.SetActive(true);
	}
	
	public void cancelClicked()
	{
		gamescreen.SetActive(true);
		speed_button.SetActive(true);
		bag_button.SetActive(true);
		inside_bag.SetActive(false);
		inside_ascension.SetActive(false);
	}
	
	public void tab_upgradeClicked()
	{
		tab_option_upgrade.SetActive(true);
		
	}
	public void tab_achievementClicked()
	{
		tab_option_achievement.SetActive(true);
		
	}
	public void tab_opsiClicked()
	{
		tab_option_opsi.SetActive(true);
		
	}
	
	public void tab_karakterClicked()
	{
		tab_option_character.SetActive(true);
		
	}
	
	public void OKClicked()
	{
		tab_option_upgrade.SetActive(false);
		tab_option_achievement.SetActive(false);
		tab_option_opsi.SetActive(false);
		tab_option_character.SetActive(false);
		
	}
	
	public void BatalClicked()
	{
		
		tab_option_opsi.SetActive(false);
		tab_option_character.SetActive(false);
		
	}
}
