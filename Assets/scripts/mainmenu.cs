using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour {


	public Touch touch;

	public UnityEngine.UI.Image Pnl_menu;

	public UnityEngine.UI.Text Txt_maintit;
	public UnityEngine.UI.Text Txt_byme;

	public UnityEngine.UI.Button Btn_strt;
	public UnityEngine.UI.Button Btn_quit;
	public UnityEngine.UI.Button Btn_opts;

	public UnityEngine.UI.Image Pnl_opts;

	public UnityEngine.UI.Text Txt_optstit;
	public UnityEngine.UI.Text Txt_optlang;
	public UnityEngine.UI.Text Txt_optres;

	public UnityEngine.UI.ScrollRect Scr_lang;
	public UnityEngine.UI.ScrollRect Scr_res;

	public UnityEngine.UI.Button Tmp_btn;

	public UnityEngine.UI.Button Btn_optsave;
	public UnityEngine.UI.Button Btn_return;

	void Start () {
		varbank.isGameInit = false;
		langopts.langrst ();

//		if(Input.deviceOrientation.ToString().Contains("Land")){
//			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x/2);
//			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, varbank.Cur_asp.y);
//
//			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x/2);
//			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, varbank.Cur_asp.y);
//
//		}
//		else {
			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x);
			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, varbank.Cur_asp.y/2);

			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x);
			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, varbank.Cur_asp.y/2);

//		}

		txtUpdate ();

		varbank.isGameInit = true;

	}

	void Update () {
		
//		if(Input.deviceOrientation.ToString().Contains("Port")){
			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x);
			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, varbank.Cur_asp.y/2);

			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x);
			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, varbank.Cur_asp.y/2);

//		}
//		else if(Input.deviceOrientation.ToString().Contains("Land")){
//			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x/2);
//			Pnl_menu.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, varbank.Cur_asp.y);
//
//			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, varbank.Cur_asp.x/2);
//			Pnl_opts.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, varbank.Cur_asp.y);
//
//		}
			
	}

	public void txtUpdate(){

		Txt_maintit.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (36.0f / varbank.Asp_scale.y);
		Txt_maintit.text = langopts.Txt_maintit;
		Txt_maintit.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Pnl_menu.rectTransform.sizeDelta.x * 3 / 4);
		Txt_maintit.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_maintit.fontSize * 1.3f));
		Txt_maintit.rectTransform.anchoredPosition = new Vector2 (0, Mathf.CeilToInt (-56.0f / varbank.Asp_scale.y));

		Txt_byme.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (-4.0f / varbank.Asp_scale.y);
		Txt_byme.text = "Ozan Tayar"; // langopts.Txt_byme;
		Txt_byme.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Pnl_menu.rectTransform.sizeDelta.x * 2 / 5);
		Txt_byme.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_byme.fontSize * 1.3f));
		Txt_byme.rectTransform.anchoredPosition = new Vector2 (0, Mathf.CeilToInt (24.0f / varbank.Asp_scale.y));

		RectTransform Rtr_strt = Btn_strt.gameObject.transform as RectTransform;
		UnityEngine.UI.Text Txt_strt = Rtr_strt.GetChild(0).GetComponent<UnityEngine.UI.Text>();
		Txt_strt.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (36.0f / varbank.Asp_scale.y);
		Txt_strt.text = langopts.Btn_txt_strt;
		//Btn_strt.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, varbank.Cur_asp.x * 3 / 5);
		Rtr_strt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Pnl_menu.rectTransform.sizeDelta.x * 3 / 5);
		Rtr_strt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_strt.fontSize * 2f));
		Rtr_strt.anchoredPosition = new Vector2 (0, Mathf.CeilToInt (24.0f / varbank.Asp_scale.y));

		RectTransform Rtr_quit = Btn_quit.gameObject.transform as RectTransform;
		UnityEngine.UI.Text Txt_quit = Rtr_quit.GetChild(0).GetComponent<UnityEngine.UI.Text>();
		Txt_quit.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (28.0f / varbank.Asp_scale.y);
		Txt_quit.text = langopts.Btn_txt_quit;
		int lngt;
		if (25 + 25 + (Txt_quit.fontSize / 2f) * Txt_quit.text.Length < Txt_quit.fontSize * 1.25f) {
			lngt = Mathf.CeilToInt (Txt_quit.fontSize * 1.25f);
		}
		else {
			lngt = Mathf.CeilToInt (25 + 25 + (Txt_quit.fontSize / 2f) * Txt_quit.text.Length);
		}
		Rtr_quit.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, lngt);
		Rtr_quit.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_quit.fontSize * 1.25f));
		Rtr_quit.anchoredPosition = new Vector2 (Mathf.CeilToInt (-16.0f / varbank.Asp_scale.x), Mathf.CeilToInt (16.0f / varbank.Asp_scale.y));

		RectTransform Rtr_opts = Btn_opts.gameObject.transform as RectTransform;
		UnityEngine.UI.Text Txt_opts = Rtr_opts.GetChild(0).GetComponent<UnityEngine.UI.Text>();
		Txt_opts.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (16.0f / varbank.Asp_scale.y);
		Txt_opts.text = langopts.Btn_txt_opts;
		Rtr_opts.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Pnl_menu.rectTransform.sizeDelta.x * 2.65f / 5);
		Rtr_opts.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_opts.fontSize * 2f));
		Rtr_opts.anchoredPosition = new Vector2 (0, Mathf.CeilToInt (-36.0f / varbank.Asp_scale.y));

		Txt_optstit.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (36.0f / varbank.Asp_scale.y);
		Txt_optstit.text = langopts.Txt_optstit;
		Txt_optstit.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Pnl_opts.rectTransform.sizeDelta.x * 3 / 4);
		Txt_optstit.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_optstit.fontSize * 1.3f));
		Txt_optstit.rectTransform.anchoredPosition = new Vector2 (0, Mathf.CeilToInt (-56.0f / varbank.Asp_scale.y));

		Txt_optlang.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (10.0f / varbank.Asp_scale.y);
		Txt_optlang.text = langopts.Txt_optlang;
		Txt_optlang.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Pnl_opts.rectTransform.sizeDelta.x * 3 / 8);
		Txt_optlang.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_optlang.fontSize * 2.6f));
		Txt_optlang.rectTransform.anchoredPosition = new Vector2 (Mathf.CeilToInt (-120.0f / varbank.Asp_scale.x), Mathf.CeilToInt (236.0f / varbank.Asp_scale.y));

		RectTransform Rtr_scrlangcont = Scr_lang.content.gameObject.transform as RectTransform;
		Rtr_scrlangcont.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt ((20.0f + 260f * varbank.Lst_lang.Length) / varbank.Asp_scale.x));
		Rtr_scrlangcont.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (200.0f / varbank.Asp_scale.y));

		RectTransform Rtr_scrlang = Scr_lang.gameObject.transform as RectTransform;
		Rtr_scrlang.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (600.0f / varbank.Asp_scale.x));
		Rtr_scrlang.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (200.0f / varbank.Asp_scale.y));
		Rtr_scrlang.anchoredPosition = new Vector2 (Mathf.CeilToInt (500f / varbank.Asp_scale.x), Mathf.CeilToInt (236f / varbank.Asp_scale.y));

		for (int i = Scr_lang.content.childCount - 1; i >= 0; i--) {
			Destroy (Scr_lang.content.GetChild (i).gameObject);
		}

		for (int i = 0; i < varbank.Lst_lang.Length; i++) { //butt check
			UnityEngine.UI.Button btn = Instantiate (Tmp_btn);
			btn.name = varbank.Lst_lang [i];
			btn.transform.SetParent (Scr_lang.content);

			if (btn.name == varbank.Sel_lang) {
				btn.interactable = false;
			}
			else {
				btn.interactable = true;
			}

			RectTransform Rtr_btn = btn.gameObject.transform as RectTransform;
			UnityEngine.UI.Text Txt = Rtr_btn.GetChild(0).GetComponent<UnityEngine.UI.Text>();
			Txt.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (36.0f / varbank.Asp_scale.y);
			Txt.text = varbank.Lst_lang [i];
			Rtr_btn.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (240.0f / varbank.Asp_scale.x));
			Rtr_btn.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (160.0f / varbank.Asp_scale.y));
			Rtr_btn.anchoredPosition = new Vector2 (Mathf.CeilToInt ((20.0f + 260f * i) / varbank.Asp_scale.x), 0);

//			if (!varbank.isGameInit) {
			btn.onClick.AddListener (() => Btnfuns.sel_lang (Txt.text, btn.transform.parent.gameObject));
//			}

		}

		Txt_optres.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (10.0f / varbank.Asp_scale.y);
		Txt_optres.text = langopts.Txt_optres;
		Txt_optres.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Pnl_opts.rectTransform.sizeDelta.x * 3 / 8);
		Txt_optres.rectTransform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Mathf.CeilToInt (Txt_optres.fontSize * 2.6f));
		Txt_optres.rectTransform.anchoredPosition = new Vector2 (Mathf.CeilToInt (-120.0f / varbank.Asp_scale.x), Mathf.CeilToInt (-24.0f / varbank.Asp_scale.y));

		RectTransform Rtr_scrrescont = Scr_res.content.gameObject.transform as RectTransform;
		Rtr_scrrescont.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt ((20.0f + 360f * varbank.Lst_res.Length) / varbank.Asp_scale.x));
		Rtr_scrrescont.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (200.0f / varbank.Asp_scale.y));

		RectTransform Rtr_scrres = Scr_res.gameObject.transform as RectTransform;
		Rtr_scrres.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (600.0f / varbank.Asp_scale.x));
		Rtr_scrres.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (200.0f / varbank.Asp_scale.y));
		Rtr_scrres.anchoredPosition = new Vector2 (Mathf.CeilToInt (500f / varbank.Asp_scale.x), Mathf.CeilToInt (-24f / varbank.Asp_scale.y));

		for (int i = Scr_res.content.childCount - 1; i >= 0; i--) {
			Destroy (Scr_res.content.GetChild (i).gameObject);
		}

		for (int i = 0; i < varbank.Lst_res.Length; i++) { //butt check
			UnityEngine.UI.Button btn = Instantiate (Tmp_btn);
			btn.name = varbank.Lst_res [i];
			btn.transform.SetParent (Scr_res.content);

			if (btn.name == varbank.Sel_res) {
				btn.interactable = false;
			}
			else {
				btn.interactable = true;
			}
			RectTransform Rtr_btn = btn.gameObject.transform as RectTransform;
			UnityEngine.UI.Text Txt = Rtr_btn.GetChild(0).GetComponent<UnityEngine.UI.Text>();
			Txt.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (36.0f / varbank.Asp_scale.y);
			Txt.text = varbank.Lst_res[i];
			Rtr_btn.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (340f / varbank.Asp_scale.x));
			Rtr_btn.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (160.0f / varbank.Asp_scale.y));
			Rtr_btn.anchoredPosition = new Vector2 (Mathf.CeilToInt ((20.0f + 360f * i) / varbank.Asp_scale.x), 0);

//			if (!varbank.isGameInit) {
			btn.onClick.AddListener (() => Btnfuns.sel_res (Txt.text, btn.transform.parent.gameObject));
//			}

		}

		RectTransform Rtr_optsave = Btn_optsave.gameObject.transform as RectTransform;
		UnityEngine.UI.Text Txt_optsave = Rtr_optsave.GetChild(0).GetComponent<UnityEngine.UI.Text>();
		Txt_optsave.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (16.0f / varbank.Asp_scale.y);
		Txt_optsave.text = langopts.Btn_txt_optsave;
		Rtr_optsave.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (360.0f / varbank.Asp_scale.x));
		Rtr_optsave.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (152.0f / varbank.Asp_scale.y));
		Rtr_optsave.anchoredPosition = new Vector2 (Mathf.CeilToInt (-200.0f / varbank.Asp_scale.x), Mathf.CeilToInt (56.0f / varbank.Asp_scale.y));

		RectTransform Rtr_return = Btn_return.gameObject.transform as RectTransform;
		UnityEngine.UI.Text Txt_return = Rtr_return.GetChild(0).GetComponent<UnityEngine.UI.Text>();
		Txt_return.fontSize = varbank.Cur_fontsize + Mathf.CeilToInt (16.0f / varbank.Asp_scale.y);
		Txt_return.text = langopts.Btn_txt_return;
		Rtr_return.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.CeilToInt (360.0f / varbank.Asp_scale.x));
		Rtr_return.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.CeilToInt (152.0f / varbank.Asp_scale.y));
		Rtr_return.anchoredPosition = new Vector2 (Mathf.CeilToInt (200.0f / varbank.Asp_scale.x), Mathf.CeilToInt (56.0f / varbank.Asp_scale.y));

	}

	public void resUpdate(){
		Screen.SetResolution (Mathf.CeilToInt (varbank.Max_asp.x / varbank.Mult_res), Mathf.CeilToInt (varbank.Max_asp.y / varbank.Mult_res), false);
	}
}
