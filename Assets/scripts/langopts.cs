using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class langopts : MonoBehaviour
{
	static public string Txt_maintit;

	static public string Btn_txt_strt;
	static public string Btn_txt_quit;
	static public string Btn_txt_opts;

	static public string Txt_optstit;
	static public string Txt_optlang;
	static public string Txt_optres;

	static public string Btn_txt_optsave;
	static public string Btn_txt_return;

	void Start(){
		varbank.isGameInit = false;
		langrst ();
		varbank.isGameInit = true;
	}

	static public void langrst (){
		
		if (varbank.Sel_lang == "ENG"){ // eng

			Txt_maintit = "Main Menu";

			Btn_txt_strt = "Start";
			Btn_txt_quit = "X";
			Btn_txt_opts = "Options";

			Txt_optstit = "Options";
			Txt_optlang = "Language:";
			Txt_optres = "Graphics:" + "\n (WIP)";

			varbank.Lst_res[0] = "High";
			varbank.Lst_res[1] = "Mid";
			varbank.Lst_res[2] = "Low";

			Btn_txt_optsave = "Apply";
			Btn_txt_return = "Return";

		}
		else if (varbank.Sel_lang == "TR"){//tr

			Txt_maintit = "Ana Menü";

			Btn_txt_strt = "Başla";
			Btn_txt_quit = "X";
			Btn_txt_opts = "Ayarlar";

			Txt_optstit = "Ayarlar";
			Txt_optlang = "Dil:";
			Txt_optres = "Grafikler:" + "\n (WIP)";

			varbank.Lst_res[0] = "Yüksek";
			varbank.Lst_res[1] = "Orta";
			varbank.Lst_res[2] = "Düşük";

			Btn_txt_optsave = "Uygula";
			Btn_txt_return = "Geri Dön";

		}

	}

}