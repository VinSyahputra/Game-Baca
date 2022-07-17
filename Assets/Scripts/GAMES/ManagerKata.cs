using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
public class ManagerKata : MonoBehaviour
{
	public static ManagerKata Instance {get; private set;}
	[SerializeField] private GameObject gameSelesai, gameGagal;
	[SerializeField] Drag hurufPrefab;
	[SerializeField] Transform slotAwal, slotAkhir;
	[SerializeField] string[] listKataKata;
	private int poinKata, poin;
	string[] kataPertama = {"SEPATU BUDI BERWARNA MERAH", "BUDI MAKAN NASI", "ANTON DUDUK DI KURSI", "KUCING ITU SEDANG TIDUR"};
    // Start is called before the first frame update
    void Start()
    {
		if(!PlayerPrefs.HasKey("number")){
			PlayerPrefs.SetInt("number", 0);
		}else{
			PlayerPrefs.GetInt("number");
		}
        Instance = this;

        InitKata(kataPertama[PlayerPrefs.GetInt("number")]);
        // InitKata(kataPertama[UnityEngine.Random.Range(0, kataPertama.Length)]);
    }

    void InitKata(string kata){
    	string hurufKata = kata;

		string[] hurufKata2 = kata.Split(' ');
    	char[] hurufAcak = new char[hurufKata2.Length];

    	List<char> hurufKataCopy = new List<char>();
    	hurufKataCopy = hurufKata.ToList();

		// random pilihan kata
		int[] rand = new int[hurufKata2.Length];
		for(int i = 0; i<hurufAcak.Length; i++){
            rand[i] = i;
        }

		// random pilihan tanpa ada yang diulang
		System.Random random = new System.Random();
        rand = rand.OrderBy(x => random.Next()).ToArray();


    	for(int i = 0; i < hurufAcak.Length; i++){
    		int randomIndex = UnityEngine.Random.Range(0, hurufKataCopy.Count);
    		hurufAcak[i] = hurufKataCopy[randomIndex];
    		hurufKataCopy.RemoveAt(randomIndex);

			

    		Drag temp = Instantiate(hurufPrefab, slotAwal);
    		temp.Inisialisasi(slotAwal, hurufKata2[rand[i]].ToString(), false);
    	}

    	for(int i = 0; i < hurufKata2.Length; i++){
			// Debug.Log("copy : " + hurufKata2.Length);
    		Drag temp = Instantiate(hurufPrefab, slotAkhir);
    		temp.Inisialisasi(slotAkhir, hurufKata2[i].ToString(), true);

    	}

    	poinKata = hurufKata2.Length;
    }

    public void TambahPoin(){
    	poin++;
    	if(poin == poinKata){
    		// Debug.Log(kataPertama.Length);
			
			PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number") + 1);
			
			if(PlayerPrefs.GetInt("number") != kataPertama.Length){
				SceneManager.LoadScene(11);
			}else{
				PlayerPrefs.SetInt("totalSkor", PlayerPrefs.GetInt("totalSkor") + 1000);
				gameSelesai.SetActive(true);
				PlayerPrefs.DeleteKey("number");
				// SceneManager.LoadScene(10);
				return;
			}
    	}
    }

	void Update(){
		if(PlayerPrefs.GetInt("timerActive") == 0){
			gameGagal.SetActive(true);
			PlayerPrefs.DeleteKey("number");
		}
	}
}
