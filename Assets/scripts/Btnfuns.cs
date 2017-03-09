using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Btnfuns : MonoBehaviour
{

	static public varbank databank;

	public Canvas Cnv_main;

	public UnityEngine.UI.Image Pnl_menu;
	public UnityEngine.UI.Image Pnl_opts;

	public Touch touch;


	void Start () {
		databank = GameObject.Find ("varbank").GetComponent<varbank> ();
	}

	public void tap_strt(){
		SceneManager.LoadScene (varbank.Scene_Last);
		
	}

	public void tap_quit(){
		varbank.SaveData ();
		Application.Quit ();
	}

	public void tap_opts(){
		Pnl_menu.rectTransform.anchoredPosition = new Vector2 (-varbank.Cur_asp.x, -varbank.Cur_asp.y);
		Pnl_menu.gameObject.SetActive (false);
		Pnl_opts.rectTransform.anchoredPosition = new Vector2 (0,0);
		Pnl_opts.gameObject.SetActive (true);
	}

	static public void sel_lang(string sel, GameObject parnt){
		varbank.SelLangUpdate (sel);
		for (int i = parnt.transform.childCount - 1; i >= 0; i--) {
			if (parnt.transform.GetChild (i).name.Contains (sel)) {
				parnt.transform.GetChild (i).GetComponent<Button> ().interactable = false;
			}
			else {
				parnt.transform.GetChild (i).GetComponent<Button> ().interactable = true;
			}
		}
	}

	static public void sel_res(string sel, GameObject parnt){
		varbank.SelResUpdate (sel);
		for (int i = parnt.transform.childCount - 1; i >= 0; i--) {
			if (parnt.transform.GetChild (i).name.Contains (sel)) {
				parnt.transform.GetChild (i).GetComponent<Button> ().interactable = false;
			}
			else {
				parnt.transform.GetChild (i).GetComponent<Button> ().interactable = true;
			}
		}
	}

	public void tap_optsave(){
		
		int j = 0;
		for (int i = 0; i < varbank.Lst_lang.Length; i++) {
			if (varbank.Sel_lang.Contains (varbank.Lst_lang [i])) {
				j = i;
			}
		}
		int k = 0;
		for (int i = 0; i < varbank.Lst_res.Length; i++) {
			if (varbank.Sel_res.Contains (varbank.Lst_res [i])) {
				k = i;
			}
		}

		langopts.langrst ();

		varbank.Sel_lang = varbank.Lst_lang [j];
		varbank.Sel_res = varbank.Lst_res [k];

		varbank.SaveData ();

		Cnv_main.GetComponent<mainmenu>().txtUpdate ();
//		Cnv_main.GetComponent<mainmenu>().resUpdate (); //VIP
	}

	public void tap_return(){
		Pnl_opts.rectTransform.anchoredPosition = new Vector2 (-varbank.Cur_asp.x, -varbank.Cur_asp.y);
		Pnl_opts.gameObject.SetActive (false);
		Pnl_menu.rectTransform.anchoredPosition = new Vector2 (0,0);
		Pnl_menu.gameObject.SetActive (true);
	}

}