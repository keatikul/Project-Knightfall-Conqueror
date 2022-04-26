using UnityEngine;
using System.Collections;

public class FrequencyTresholdSpawner : MonoBehaviour {

	//ZMIENNE
	//Obiekt
	public GameObject objectPrefab;
	//treshold
	public float spawnThreshold = 0.05f;
	//Frequency
	public int frequency;
	//Window
	public FFTWindow fftWindow;
	
	GameObject clone;
	
	//ZMIENNA ILOSC SAMPLI
	private float[] samples = new float[4096]; //MUST BE A POWER OF TWO
	
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//GETSPECTRUMDATA
		AudioListener.GetSpectrumData(samples, 0, fftWindow);
		//Tworzenie Obiektu
		Debug.Log(samples[frequency]);
		if(samples[frequency] > spawnThreshold)// && clone != null)
		{
			clone = (GameObject)Instantiate(objectPrefab, new Vector3(Random.Range(-10.0f, 10.0f), 5, 0), Quaternion.identity);
		}
		else
			clone = null;
	}
	
	
}


