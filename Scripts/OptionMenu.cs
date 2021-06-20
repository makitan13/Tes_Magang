using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
	
	public GameObject tab_upgrade;
	public GameObject tab_pencapaian;
	public GameObject tab_opsi;
	public GameObject tab_karakter;
    // Start is called before the first frame update
    void Start()
    {
        tab_upgrade.SetActive(false);
		tab_pencapaian.SetActive(false);
		tab_opsi.SetActive(false);
		tab_karakter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
