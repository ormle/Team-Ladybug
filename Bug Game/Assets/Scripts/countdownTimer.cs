using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 46.9f;
	public string textValue = "Timer: ";
	public TextMeshProUGUI textElement;
	public TextMeshProUGUI timesUp;
	public StateLoader stateloader;
	public Image timerBar;
	public GameObject banner;
	public GameObject ant1;
	public GameObject ant2;
	public GameObject ant3;
	public GameObject ant4;
	public GameObject ant5;
	public GameObject ant6;

	public GameObject bugSpawner;

	public GameObject sLoader;
	private StateLoader stateLoaderscript;

	private bool startTime = false;

	// Start is called before the first frame update
	void Start()
    {
		StartCoroutine(WaitForStart());

		//banner.SetActive(false);
		timesUp.enabled = false;
        currentTime = startingTime;
		stateLoaderscript = sLoader.GetComponent<StateLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime == 3f) { 
			//3 2 1
			//Debug.Log("here");
        }
		currentTime -= 1 * Time.deltaTime;

		if (startTime)
		{
			timerBar.fillAmount = currentTime / startingTime;
			textElement.text = textValue + ((int)System.Math.Round(currentTime)).ToString();
		}

		if (currentTime <= 13) {
			banner.transform.position += -transform.right * 5 * Time.deltaTime;

			// deals with if the ant that pulls the banner is deleted or not
			if(ant1 != null) {
				ant1.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			if(ant2 != null) {
				ant2.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			if(ant3 != null) {
				ant3.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			if(ant4 != null) {
				ant4.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			if(ant5 != null) {
				ant5.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			if(ant6 != null) {
				ant6.transform.position += -transform.right * 5 * Time.deltaTime;
			}
			
			//transform.position += transform.forward * speed * Time.deltaTime;		
			//print("HERE!!!!!!!!!!!!!!!!!") ;
		}
		if (currentTime <= 0)
		{
			// Debug.Log("current time:" + currentTime);
			timesUp.enabled = true;
			//timesUp.GetComponent<Animator>().Play("Default.TimesUp");
			banner.SetActive(false);
			Time.timeScale = 0;
			//	TIMES UP animation
			//NextState();
			new WaitForSecondsRealtime(2);
			StartCoroutine(stateLoaderscript.LoadState(3));
			
		}
	}

	IEnumerator WaitForStart() {
		yield return new WaitForSecondsRealtime(1.5f);
		startTime = true;
	}

	/*public void NextState()
	{
		StartCoroutine(LoadState(SceneManager.GetActiveScene().buildIndex + 1));
	}

	IEnumerator LoadState(int sceneIndex)
	{
		yield return new WaitForSecondsRealtime(2f);
		transition.SetTrigger("TimeUp");
		SceneManager.LoadScene(sceneIndex);
		Time.timeScale = 1;
	}*/
}
