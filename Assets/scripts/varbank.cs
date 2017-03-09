using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class varbank: MonoBehaviour
{
	static public varbank databank;

	static public string Pth_Deflt;
	static public string Pth_Opts;
	static public string Pth_Prefabs;

	static public bool isGameInit = false;
	static public bool isFirstPlay;

	static public int Std_fontsize;
	static public Vector2 Std_asp;
	static public Vector2 Cur_asp;
	static public Vector2 Max_asp;
	static public Vector2 Asp_scale;
	static public int Cur_fontsize;

	static public string[] Lst_lang;
	static public string[] Lst_res;

	static public string Sel_lang;
	static public string Sel_res;
	static public string Scene_Last;

	static public int Mult_res;

	void Awake(){
		if (databank == null) {
			DontDestroyOnLoad (gameObject);
			databank = this;
		}
		else if (databank != this) {
			Destroy (gameObject);
		}

	}

	void Start(){
		isGameInit = false;

		Pth_Deflt = Application.persistentDataPath;
		Pth_Opts = "/Opts.dat";
		Pth_Prefabs = "prefabs/";
		
		#region init 01
		Lst_lang = new string[2];
		Lst_lang [0] = "ENG";
		Lst_lang [1] = "TR";
		Sel_lang = Lst_lang[0];
		Lst_res = new string[3];
		Lst_res [0] = "High";
		Lst_res [1] = "Mid";
		Lst_res [2] = "Low";
		Sel_res = Lst_res[0];

		#endregion

		#region init 02
		#endregion

		#region init 03
		#endregion

		#region init 04
		#endregion

		#region init 05
		LoadData ();

		Mult_res = 1;

		SelLangUpdate (Sel_lang);
		SelResUpdate (Sel_res);

		Std_fontsize = 56;
		Std_asp.x = 1080;
		Std_asp.y = 1920;
		Cur_asp.x = Mathf.RoundToInt (Screen.width / Mult_res);
		Cur_asp.y = Mathf.RoundToInt (Screen.height / Mult_res);
		Max_asp = Cur_asp;
		Asp_scale = new Vector2 (Mathf.RoundToInt (Std_asp.x / Cur_asp.x), Mathf.RoundToInt (Std_asp.y / Cur_asp.y));
		Cur_fontsize = Mathf.RoundToInt ((1f * Std_fontsize) / Asp_scale.y);

		langopts.langrst ();
		#endregion

		isGameInit = true;
	}

	void Update(){
		
	}

	static public void SelLangUpdate(string sellang = "ENG"){
		for (int i = 0; i < Lst_lang.Length; i++) {
			if (sellang == Lst_lang [i]) {
				Sel_lang = Lst_lang [i];
			}
		}
	}

	static public void SelResUpdate(string selres = "High"){
		for (int i = 0; i < Lst_res.Length; i++) {
			if (selres == Lst_res [i]) {
				Sel_res = Lst_res [i];
			}
		}
	}

	static public void SaveData(){
		BinaryFormatter Bff = new BinaryFormatter ();

		if (File.Exists (Pth_Deflt + Pth_Opts)) {
			File.Delete (Pth_Deflt + Pth_Opts);
		}
		FileStream file = File.Create (Pth_Deflt + Pth_Opts);

		DataFrmt data = new DataFrmt ();
		data.isFirstPlay = isFirstPlay;
		data.Sel_lang = Sel_lang;
		data.Sel_res = Sel_res;
		data.Scene_Last = Scene_Last;

		Bff.Serialize (file, data);
		file.Close ();
	}

	static public void LoadData(){
		if (File.Exists (Pth_Deflt + Pth_Opts)) {
			BinaryFormatter Bff = new BinaryFormatter ();

			FileStream file = File.Open (Pth_Deflt + Pth_Opts, FileMode.Open);

			DataFrmt data = (DataFrmt)Bff.Deserialize (file);
			file.Close ();

			isFirstPlay = data.isFirstPlay;
			Sel_lang = data.Sel_lang;
			Sel_res = data.Sel_res;
			Scene_Last = data.Scene_Last;
		}
		else {
			isFirstPlay = true;
			Sel_lang = Lst_lang [0];
			Sel_res = Lst_res [0];
			Scene_Last = "Splash";
		}

	}

	void OnApplicationQuit(){
		//		SaveData ();
	}

}

[Serializable]
class DataFrmt {
	public bool isFirstPlay;
	public string Sel_lang;
	public string Sel_res;
	public string Scene_Last;

//	public DataFrmt(bool new_isFirstPlay,string new_Sel_lang,string new_Sel_res,string new_Scene_Last,int new_at_Story,List<float> new_Elems,List<bool> new_isElem){
//		isFirstPlay = new_isFirstPlay;
//		Sel_lang = new_Sel_lang;
//		Sel_res = new_Sel_res;
//		Scene_Last = new_Scene_Last;
//		at_Story = new_at_Story;
//		Elems = new_Elems;
//		isElem = new_isElem;
//	}
}